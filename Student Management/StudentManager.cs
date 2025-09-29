using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Student_Management
{
    public class StudentManager
    {
        public BindingList<Student> dsSinhVien { get; private set; }
        private IStudentStorage storage;
        private string filePath;

        public StudentManager(IStudentStorage storage)
        {
            this.storage = storage;
            dsSinhVien = new BindingList<Student>();    
        }

        public void UpdateStorage(IStudentStorage newStorage)
        {
            storage = newStorage;
            dsSinhVien.Clear();
        }

        public void LoadFrom(string filePath)
        {
            this.filePath = filePath;
            dsSinhVien.Clear();
            var students= storage.ReadFromFile(filePath);
            foreach( var sv in students.Where(s => s != null))
            {
                dsSinhVien.Add(sv);
            }
        }

        public void SaveTo()
        {
            if (string.IsNullOrEmpty(this.filePath))
            {
                throw new InvalidOperationException("Không thể lưu file vì đường dẫn chưa được thiết lập. Vui lòng tải hoặc chọn file lưu trước.");
            }
            storage.WriteToFile(filePath, dsSinhVien.ToList());
        }

        // Xử lý thêm sinh viên vào danh sách quản lý
        #region
        public bool AddStudent(Student sv)
        {
            if (sv == null)
            {
                return false;
            }
            for (int i = 0; i < dsSinhVien.Count; i++)
            {
                if (dsSinhVien[i].MSSV == sv.MSSV)
                {
                    return false;
                }
            }
            dsSinhVien.Add(sv);
            SaveTo(); return true;
        }
        #endregion

        // Xử lý cập nhật sinh viên
        #region
        public bool UpdateStudent(Student sv)
        {
            if (sv == null) return false;
            int index = -1;
            for (int i = 0; i < dsSinhVien.Count; i++)
            {
                if (dsSinhVien[i].MSSV == sv.MSSV)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1) return false;

            for (int i = 0; i < dsSinhVien.Count; i++)
            {
                if (i != index && dsSinhVien[i].MSSV == sv.MSSV)
                {
                    MessageBox.Show($"MSSV '{sv.MSSV}' đã tồn tại trong danh sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            dsSinhVien[index].MSSV = sv.MSSV;
            dsSinhVien[index].HoTenLot = sv.HoTenLot;
            dsSinhVien[index].Ten = sv.Ten;
            dsSinhVien[index].NgaySinh = sv.NgaySinh;
            dsSinhVien[index].Lop = sv.Lop;
            dsSinhVien[index].CMND = sv.CMND;
            dsSinhVien[index].SoDienThoai = sv.SoDienThoai;
            dsSinhVien[index].DiaChi = sv.DiaChi;
            dsSinhVien[index].GioiTinh = sv.GioiTinh;
            dsSinhVien[index].MonHocDKy = sv.MonHocDKy;
            return true;
        }
        #endregion

        // Lấy danh sách các môn đã được đăng ký trên hệ thống
        #region
        public List<string> GetAllMasterSubjects()
        {
            var allSubjects = new HashSet<string>();
            if(dsSinhVien != null)
            {
                foreach (var sv in dsSinhVien)
                {
                    if (sv.MonHocDKy != null)
                    {
                        foreach (var monHoc in sv.MonHocDKy)
                        {
                            allSubjects.Add(monHoc);
                        }
                    }
                }
            }
            return allSubjects.ToList();

        }
        #endregion

        // Xóa một hoặc nhiều môn ra khỏi toàn bộ dữ liệu sinh viên
        #region
        public void AddMasterSubject(string subject)
        {

        }

        public void LoadMonHocToCLB(CheckedListBox clb)
        {
            clb.Items.Clear();
            foreach (var s in GetAllMasterSubjects())
                clb.Items.Add(s);
        }
        #endregion
    }
}
