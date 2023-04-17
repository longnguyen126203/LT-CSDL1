using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<StudentInfo> Form1_Load(object sender, EventArgs e)
        {
            
            List<StudentInfo> List = new List<StudentInfo>();
            // Đối tượng đọc tập tin
            StreamReader r = new StreamReader("DanhSachSV.json");
            string json = r.ReadToEnd();
            // Chuyển về thành mảng các đối tượng
            var array = (JObject)JsonConvert.DeserializeObject(json);
            // Lấy đối tượng sinhvien
            var students = array["sinhvien"].Children();
            foreach (var item in students) // Duyệt mảng
            {
                // Lấy các thành  phần
                string mssv = item["MSSV"].Value<string>();
                string hoten = item["hoten"].Value<string>();
                int tuoi = item["tuoi"].Value<int>();
                double diem = item["diem"].Value<double>();
                bool tongiao = item["tongiao"].Value<bool>();
                // Chuyển vào đối tượng StudenInfo
                StudentInfo info = new StudentInfo(mssv, hoten, tuoi, diem, tongiao);
                List.Add(info);
            }
            return List;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Str = ""; // chuỗi lưu trữ
            string Path = "../../JSONExample.json"; // Đường dẫn tập tin
            List<StudentInfo> List = Form1_Load("DanhSachSV.json"); // Gọi phương thức
            for (int i = 0; i < List.Count; i++) // Đọc danh sách
            {
                StudentInfo info = List[i];
                Str += string.Format("Sinh viên {0} có MSSV: {1}, họ tên: {2}, điêm TB: {3}\r\n", (i + 1), info.MSSV, info.Hơten, info.Diem);
            }
            MessageBox.Show(Str);
        }

        
    }
}
