using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Lab05
{
    class QLSinhVien
    {
        public List<SinhVien> DanhSach = new List<SinhVien>();

        public QLSinhVien()
        {

        }



        public void DocFile(string fileSrc)
        {
            StreamReader str = new StreamReader(fileSrc);
            string line;
            string[] value;
            string[] monhoc;
            SinhVien sv;
            while ((line = str.ReadLine()) != null)
            {

                value = line.Split('*');
                sv = new SinhVien();
                sv.mssv = value[0];
                sv.hoLot = value[1];
                sv.ten = value[2];
                sv.diaChi = value[3];
                sv.ngaySinh = DateTime.ParseExact(value[4], "dd/MM/yyyy", CultureInfo.InstalledUICulture);
                sv.gioiTinh = true;
                if (Int32.Parse(value[5]) == 0)
                {
                    sv.gioiTinh = false;
                }
                sv.lop = value[6];
                sv.soDT = value[7];
                sv.cmnd = value[8];
                monhoc = value[9].Split(',');
                for (int i = 0; i < monhoc.Count(); i++)
                {
                    sv.monHoc.Add(monhoc[i]);
                }
                DanhSach.Add(sv);
            }
            str.Close();
        }

        public List<SinhVien> LayTatCaThongTin()
        {
            return DanhSach;
        }

        public SinhVien LayMSSV(string MSSV)
        {
            if (string.IsNullOrWhiteSpace(MSSV))
                throw new ArgumentException($"Tên sinh viên không hợp lệ!");

            SinhVien sv = null;

            sv = DanhSach.Find(s => s.mssv == MSSV);

            return sv;
        }

        public List<SinhVien> LayTen(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException($"Tên sinh viên không hợp lệ!");

            return DanhSach.FindAll(sv => sv.ten.ToLower() == name.ToLower());
        }

        public List<SinhVien> LayLop(string className)
        {
            if (string.IsNullOrWhiteSpace(className))
                throw new ArgumentException($"Lớp không hợp lệ!");

            return DanhSach.FindAll(sv => sv.lop.ToLower() == className.ToLower());
        }

        public void CapNhatTheoMSSV(string MSSV, SinhVien sinhVienMoi)
        {
            if (string.IsNullOrWhiteSpace(MSSV))
                throw new ArgumentException($"Mã số sinh viên không hợp lệ!");

            var isExist = DanhSach.Exists(sv => sv.mssv == MSSV);
            if (!isExist)
                throw new ArgumentException($"Sinh viên có mã số {MSSV} không tồn tại!");

            var index = DanhSach.FindIndex(sv => sv.mssv == MSSV);
            DanhSach[index] = sinhVienMoi;

            //dataStorage.Write(dsSinhVien);
        }

        public void XoaTheoMSSV(string MSSV)
        {
            if (string.IsNullOrWhiteSpace(MSSV))
                throw new ArgumentException($"Mã số sinh viên không hợp lệ!");

            var sinhVien = DanhSach.Find(sv => sv.mssv == MSSV);
            if (sinhVien is null)
                throw new ArgumentException($"Không tồn tại sinh viên có mã số {MSSV}");

            DanhSach.Remove(sinhVien);
            // dataStorage.Write(dsSinhVien);
        }

        public void Them(SinhVien sinhVien)
        {
            if (sinhVien is null)
                throw new ArgumentException($"Sinh viên không hợp lệ!");

            var isExist = DanhSach.Exists(sv => sv.mssv == sinhVien.mssv);
            if (isExist)
                throw new ArgumentException($"Sinh viên có mã số {sinhVien.mssv} đã tồn tại!");

            DanhSach.Add(sinhVien);
        }
    }
}
