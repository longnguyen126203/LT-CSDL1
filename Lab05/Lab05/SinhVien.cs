using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class SinhVien
    {
        public string mssv { get; set; }
        public string hoLot { get; set; }
        public string ten { get; set; }
        public bool gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public string lop { get; set; }
        public string cmnd { get; set; }
        public string soDT { get; set; }
        public string diaChi { get; set; }
        public List<string> monHoc { get; set; }

        public SinhVien()
        {
            monHoc = new List<string>();
        }

        public SinhVien(string mssv, string hoLot, string ten, bool gioiTinh, string lop, 
           DateTime ngaySinh, string cmnd, string soDT, string diaChi, List<string> monHoc)
        {
            this.mssv = mssv;
            this.hoLot = hoLot;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.lop = lop;
            this.cmnd = cmnd;
            this.soDT = soDT;
            this.diaChi = diaChi;
            this.monHoc = monHoc;
        }
    }
}
