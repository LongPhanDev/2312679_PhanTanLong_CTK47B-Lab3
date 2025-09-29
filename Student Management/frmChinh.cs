using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Student_Management
{
    public partial class frmChinh : Form
    {
        private StudentManager studentManager;
        private string _filePath;

        // Phương thức khởi tạo có tham số (dùng để load file ngay)
        public frmChinh(IStudentStorage storage, string filePath)
        {
            InitializeComponent();
            this.studentManager = new StudentManager(storage);
            this._filePath = filePath;
        }
        public frmChinh()
        {
            InitializeComponent();
            this.studentManager = new StudentManager(new TextStudentStorage());
            this._filePath = string.Empty;
        }
        private void frmChinh_Load(object sender, EventArgs e)
        {
            dgvDanhsachsv.AutoGenerateColumns = false;
            if (!string.IsNullOrEmpty(this._filePath) && File.Exists(this._filePath))
            {
                LoadDataFromManager(this._filePath);
            }
        }

 
        private void LoadDataFromManager(string filePath)
        {
            try
            {
                studentManager.LoadFrom(filePath);
                dgvDanhsachsv.DataSource = studentManager.dsSinhVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        // Đọc file dữ liệu txt
        private void itemdataTxt_Click(object sender, EventArgs e)
        {
            string defaultFilePath = "students.txt";
            try
            {
                this.studentManager.UpdateStorage(new TextStudentStorage());
                this.studentManager.LoadFrom(defaultFilePath);
                dgvDanhsachsv.DataSource = null;
                dgvDanhsachsv.DataSource = studentManager.dsSinhVien;

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải file TXT:\n{ex.Message}",
                       "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Đọc file dữ liệu Json
        private void itemdataJson_Click(object sender, EventArgs e)
        {
            string defaultFilePath = "students.json";
            try
            {
                this.studentManager.UpdateStorage(new JsonStudentStorage());
                this.studentManager.LoadFrom(defaultFilePath);
                dgvDanhsachsv.DataSource = null;
                dgvDanhsachsv.DataSource = studentManager.dsSinhVien;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải file Json:\n{ex.Message}",
                       "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Đọc file dữ liệu XML
        private void itemdataXML_Click(object sender, EventArgs e)
        {
            string defaultFilePath = "students.xml";
            try
            {
                this.studentManager.UpdateStorage(new XmlStudentStorage());
                this.studentManager.LoadFrom(defaultFilePath);
                dgvDanhsachsv.DataSource = null;
                dgvDanhsachsv.DataSource = studentManager.dsSinhVien;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải file XML:\n{ex.Message}",
                       "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region Kiểm tra tính hợp lệ
        private bool CheckValid()
        {
            if (!msktMSSV.MaskFull)
            {
                MessageBox.Show("MSSV phải đủ 7 chữ số.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                msktMSSV.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtHoTenLot.Text) || string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên lót.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenLot.Focus();
                return false;
            }

            if (cboLop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn lớp.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLop.Focus();
                return false;
            }

            if (!msktSCMND.MaskFull)
            {
                MessageBox.Show("CMND phải đủ 9 chữ số.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                msktSCMND.Focus();
                return false;
            }
            if (!msktSoDT.MaskFull)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 chữ số.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                msktSoDT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }
            if (!rdNam.Checked && !rdNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            bool daChonMon = clMonHocDangKy.CheckedItems.Count > 0;
            return true;
        }
        #endregion

        // Lấy thông tin sinh viên từ control
        #region 
        private Student GetInforFromUserControl()
        {
            string mssv = msktMSSV.Text.Trim();
            string hoTenLot = txtHoTenLot.Text;
            string ten = txtTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string lop = cboLop.SelectedItem?.ToString() ?? "";
            string cmnd = msktSCMND.Text;
            string diaChi = txtDiaChi.Text;
            string sdt = msktSoDT.Text;
            bool gioiTinh = rdNam.Checked;

            var monHocDangKy = new List<string>();
            foreach (var item in clMonHocDangKy.CheckedItems)
            {
                monHocDangKy.Add(item.ToString());
            }
            return new Student(mssv, hoTenLot, ten, ngaySinh, lop, cmnd, sdt, diaChi, gioiTinh, monHocDangKy);
        }
        #endregion
        // Thêm sinh viên vào danh sách
        #region
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (!CheckValid()) return;
            var sv = GetInforFromUserControl();
            if (studentManager.AddStudent(sv))
            {
                studentManager.SaveTo();
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại (MSSV có thể đã tồn tại)!");
            }
        }
        #endregion

        // Reset control 
        #region
        private void btnReset_Click(object sender, EventArgs e)
        {
            msktMSSV.Clear();
            txtHoTenLot.Clear();
            txtTen.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            cboLop.SelectedIndex = -1;
            rdNam.Checked = true;
            rdNu.Checked = false;
            msktSCMND.Clear();
            msktSoDT.Clear();
            for(int i = 0; i < clMonHocDangKy.Items.Count; i++)
            {
                clMonHocDangKy.SetItemChecked(i, false);
            }
            msktMSSV.Focus();
        }
        #endregion

        // Khi người dùng chọn dòng, hiển thị thông tin sinh viên lên các control trên Form
        private void dgvDanhsachsv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhsachsv.CurrentRow != null)
            {
                var sv = dgvDanhsachsv.CurrentRow.DataBoundItem as Student;
                if (sv != null)
                {
                    msktMSSV.Text = sv.MSSV;
                    txtHoTenLot.Text = sv.HoTenLot;
                    txtTen.Text = sv.Ten;
                    dtpNgaySinh.Value = sv.NgaySinh;
                    cboLop.SelectedItem = sv.Lop;
                    msktSCMND.Text = sv.CMND;
                    msktSoDT.Text = sv.SoDienThoai;
                    txtDiaChi.Text = sv.DiaChi;
                    rdNam.Checked = sv.GioiTinh;
                    rdNu.Checked = !sv.GioiTinh;

                    for (int i = 0; i < clMonHocDangKy.Items.Count; i++)
                    {
                        clMonHocDangKy.SetItemChecked(i, false);
                    }

                    foreach (var monDangKy in sv.MonHocDKy)
                    {
                        int index = clMonHocDangKy.Items.IndexOf(monDangKy);

                        if (index != -1)
                        {
                            clMonHocDangKy.SetItemChecked(index, true);
                        }
                    }
                }
            }
        }

        // Xóa sinh viên được chọn khỏi danh sách hiển thị và bộ nhớ
        private void itemDelete_Click(object sender, EventArgs e)
        {
            dgvDanhsachsv.EndEdit();
            List<string> mssvToErase = new List<string>();
            foreach (DataGridViewRow row in dgvDanhsachsv.SelectedRows)
            {
                if(row.DataBoundItem is Student sv)
                {
                    mssvToErase.Add(sv.MSSV);
                }
            }
            // Nếu không có hàng nào được chọn, kiểm tra hàng hiện tại (CurrentRow) để xóa 1 mục
            if (mssvToErase.Count == 0 && dgvDanhsachsv.CurrentRow != null)
            {
                if (dgvDanhsachsv.CurrentRow.DataBoundItem is Student sv)
                {
                    mssvToErase.Add(sv.MSSV);
                }
            }
            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa {mssvToErase.Count} sinh viên đã chọn không?",
                "Xác nhận Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int deletedCount = 0;
                for (int i = studentManager.dsSinhVien.Count - 1; i >= 0; i--)
                {
                    if (mssvToErase.Contains(studentManager.dsSinhVien[i].MSSV))
                    {
                        studentManager.dsSinhVien.RemoveAt(i);
                        deletedCount++;
                    }
                }

                try
                {
                    studentManager.SaveTo();
                    MessageBox.Show($"Đã xóa thành công {deletedCount} sinh viên.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Cảnh báo Lưu File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Xử lý sự kiện thoát chương trình
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn đang thoát chương trình", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Sự kiện cập nhật sinh viên vào danh sách quản lý
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!CheckValid()) return;
            var sv = GetInforFromUserControl();
            
            if(studentManager.UpdateStudent(sv))
            {
                studentManager.dsSinhVien.ResetBindings();
                try
                {
                    studentManager.SaveTo();
                    MessageBox.Show("Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(
                        $"Lỗi lưu file: {ex.Message}\nDữ liệu đã được cập nhật trong bộ nhớ. Vui lòng kiểm tra lại đường dẫn file hoặc quyền ghi.",
                        "Cảnh báo Lưu File",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại! Vui lòng kiểm tra MSSV và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Mở form Tìm kiếm và thực hiện 
        #region
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmSearch(studentManager.dsSinhVien.ToList()))
            {
                frm.OnSearchCompleted += result =>
                {
                    dgvDanhsachsv.DataSource = null;
                    dgvDanhsachsv.DataSource = result;
                };
                frm.ShowDialog();
            }
        }
        #endregion

        //Truy cập Control UI (DataGridView, ListBox) để lấy thông tin chọn.
        #region
        public Student GetSelectedStudentFromUI()
        {
            if(dgvDanhsachsv.CurrentRow != null && dgvDanhsachsv.CurrentRow.DataBoundItem is Student sv)
            {
                return sv;
            }
            return null;
        }
        #endregion

        // Nạp môn học vào CheckedListBox
        #region
        private void LoadSubjectsToCheckedListBox()
        {
            clMonHocDangKy.Items.Clear();
            var danhSachMon = studentManager.GetAllMasterSubjects();
            foreach (var mon in danhSachMon)
                clMonHocDangKy.Items.Add(mon, false); 
        }
        #endregion

        // Sự kiện Thêm môn
        #region
        private void ctmsThem_Click(object sender, EventArgs e)
        {
            frmAddmonhoc frm = new frmAddmonhoc();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                string tenMH = frm.TenMH;

                // Kiểm tra trùng lặp
                var allSubjects = studentManager.GetAllMasterSubjects();
                if (allSubjects.Any(s => string.Equals(s, tenMH, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show($"Môn học '{tenMH}' đã tồn tại.", "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thêm vào sinh viên đầu tiên để lưu vào file
                if (studentManager.dsSinhVien.Count == 0)
                {
                    MessageBox.Show("Không có sinh viên nào để thêm môn học. Vui lòng thêm sinh viên trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var sv = studentManager.dsSinhVien[0];
                sv.MonHocDKy.Add(tenMH);

                studentManager.SaveTo();

                LoadSubjectsToCheckedListBox();

                MessageBox.Show($"Đã thêm môn '{tenMH}' thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        // Sự kiện Xóa môn
        #region
        private void ctmsXoa_Click(object sender, EventArgs e)
        {
            if (clMonHocDangKy.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một môn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var subjectsToRemove = clMonHocDangKy.CheckedItems.Cast<string>().ToList();

            // Kiểm tra ràng buộc
            foreach (var sv in studentManager.dsSinhVien)
            {
                if (sv.MonHocDKy.Any(m => subjectsToRemove.Contains(m)))
                {
                    MessageBox.Show("Không thể xóa vì vẫn còn sinh viên đang học các môn này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Xóa hoàn toàn
            foreach (var sv in studentManager.dsSinhVien)
                sv.MonHocDKy.RemoveAll(m => subjectsToRemove.Contains(m));

            studentManager.SaveTo();
            LoadSubjectsToCheckedListBox();

            MessageBox.Show("Đã xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
