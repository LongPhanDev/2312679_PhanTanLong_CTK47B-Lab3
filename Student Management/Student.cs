using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    public class Student
    {
        public string MSSV { get; set; }

        public string HoTenLot { get; set; }

        public string Ten { get; set; }

        public DateTime NgaySinh { get; set; }

        public string Lop { get; set; }

        public string CMND { get; set; }

        public string SoDienThoai { get; set; }

        public string DiaChi { get; set; }

        [Browsable(false)]
        public bool GioiTinh { get; set; }

        public List<string> MonHocDKy { get; set; }

        public Student()
        {
            MonHocDKy = new List<string>();
        }
        public Student(string ms, string hoTenLot, string ten, DateTime ngaySinh, string lop, string cmnd, string sodt, string diaChi, bool gioiTinh, List<string> monHoc)
        {
            this.MSSV = ms;
            this.HoTenLot = hoTenLot;
            this.Ten = ten;
            this.NgaySinh = ngaySinh;
            this.Lop = lop;
            this.CMND = cmnd;
            this.SoDienThoai = sodt;
            this.DiaChi = diaChi;
            this.GioiTinh = gioiTinh;
            this.MonHocDKy = monHoc;
        }
        public static Student Parse(string line)
        {
            if (string.IsNullOrWhiteSpace(line))
                return null;

            var parts = line.Trim().Split('#');
            if (parts.Length < 10)
                return null;

            try
            {
                var monHocList = parts[9].Trim()
                                         .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(m => m.Trim())
                                         .ToList();

                return new Student(
                    parts[0].Trim(),
                    parts[1].Trim(),
                    parts[2].Trim(),
                    DateTime.ParseExact(parts[3].Trim(), "dd/MM/yyyy", null),
                    parts[4].Trim(),
                    parts[5].Trim(),
                    parts[6].Trim(),
                    parts[7].Trim(),
                    parts[8].Trim() == "1",
                    monHocList
                );
            }
            catch (Exception ex) when (ex is FormatException || ex is ArgumentException)
            {
                return null;
            }
        }
        public override string ToString()
        {
            return $"{MSSV}#{HoTenLot}#{Ten}#{NgaySinh:dd/MM/yyyy}#{Lop}#{CMND}#{SoDienThoai}#{DiaChi}#{(GioiTinh ? "1" : "0")}#{string.Join(",", MonHocDKy)}";
        }
        public string GioiTinhText
        {
            get { return GioiTinh ? "Nam" : "Nữ"; }
        }

        public string MonHocText
        {
            get { return MonHocDKy != null ? string.Join(", ", MonHocDKy) : ""; }
        }
    }
}
