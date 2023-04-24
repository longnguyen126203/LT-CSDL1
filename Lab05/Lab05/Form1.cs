using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        QLSinhVien qlsv;

        string file = "DanhSachSV.txt";

        private void ThemSVListView(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.mssv);
            lvitem.SubItems.Add(sv.hoLot);
            lvitem.SubItems.Add(sv.ten);
            lvitem.SubItems.Add(sv.ngaySinh.ToString());
            string gt = "Nu";
            if (sv.gioiTinh)
            {
                gt = "Nam";
            }
            lvitem.SubItems.Add(gt);
            lvitem.SubItems.Add(sv.lop);
            lvitem.SubItems.Add(sv.cmnd);
            lvitem.SubItems.Add(sv.soDT);
            lvitem.SubItems.Add(sv.diaChi);
            this.lvSinhVien.Items.Add(lvitem);
        }

        public void LoadList()
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv  in qlsv.DanhSach)
            {
                ThemSVListView(sv);
            }
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            qlsv = new QLSinhVien();
            qlsv.DocFile(file);
            LoadList();
        }

        
        }
    }

