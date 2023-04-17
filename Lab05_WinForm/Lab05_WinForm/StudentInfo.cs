﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_WinForm
{
    public class StudentInfo
    {
        // Các thuộc tính
        public string MSSV { get; set; }
        public string Hơten { get; set; }
        public int Tuoi { get; set; }
        public double Diem { get; set; }
        public bool TonGiao { get; set; }

        //Phương thức tạo lập
        public StudentInfo(string mssv, string hoten, int tuoi, double diem, bool tongiao)
        {
            this.MSSV = mssv;
            this.Hơten = hoten;
            this.Tuoi = tuoi;
            this.Diem = diem;
            this.TonGiao = tongiao;
        }
    }
}
