using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class frmSearch : Form
    {
        private readonly List<Student> _fullList;
        public event Action<List<Student>> OnSearchCompleted;
        public frmSearch(List<Student> fullList)
        {
            InitializeComponent();
            _fullList = fullList;
            txtDc.Enabled = false;
            txtNamSinh.Enabled = false;
            txtGioiTinh.Enabled = false;
            cboLop.Enabled = false;
            txtMonHoc.Enabled = false;
            msktMSSV.Enabled = false;
            txtTenTK.Enabled = false;

            cbDiaChi.CheckedChanged += (s, e) => txtDc.Enabled = cbDiaChi.Checked;
            cbNamSinh.CheckedChanged += (s, e) => txtNamSinh.Enabled = cbNamSinh.Checked;
            cbGioiTinh.CheckedChanged += (s, e) => txtGioiTinh.Enabled = cbGioiTinh.Checked;
            cbLop.CheckedChanged += (s, e) => cboLop.Enabled = cbLop.Checked;
            cbMonHoc.CheckedChanged += (s, e) => txtMonHoc.Enabled = cbMonHoc.Checked;
            cbMSSV.CheckedChanged += (s, e) => msktMSSV.Enabled = cbMSSV.Checked;
            cbTenTK.CheckedChanged += (s, e) => txtTenTK.Enabled = cbTenTK.Checked;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!cbTenTK.Checked && !cbDiaChi.Checked && !cbNamSinh.Checked &&
                !cbGioiTinh.Checked && !cbLop.Checked && !cbMonHoc.Checked &&
                !cbMSSV.Checked)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một tiêu chí tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            IEnumerable<Student> query = _fullList;

            // Tìm theo Tên
            if (cbTenTK.Checked && !string.IsNullOrWhiteSpace(txtTenTK.Text))
            {
                string key = txtTenTK.Text.Trim();
                query = query.Where(s =>
                    !string.IsNullOrEmpty(s.Ten) &&
                    s.Ten.IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            // Tìm theo Địa chỉ
            if (cbDiaChi.Checked && !string.IsNullOrWhiteSpace(txtDc.Text))
            {
                string key = txtDc.Text.Trim();
                query = query.Where(s =>
                    !string.IsNullOrEmpty(s.DiaChi) &&
                    s.DiaChi.IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            // Tìm theo Năm sinh (chỉ lấy năm)
            if (cbNamSinh.Checked && int.TryParse(txtNamSinh.Text, out int year))
            {
                query = query.Where(s => s.NgaySinh.Year == year);
            }

            // Tìm theo giới tính
            if (cbGioiTinh.Checked && !string.IsNullOrWhiteSpace(txtGioiTinh.Text))
            {
                string key = txtGioiTinh.Text.Trim().ToLower();
                bool? gioiTinhTim = key.Contains("nam") ? true :
                                    key.Contains("nữ") ? false : (bool?)null;

                if (gioiTinhTim != null)
                    query = query.Where(s => s.GioiTinh == gioiTinhTim);
            }

            // Tìm theo lớp
            if (cbLop.Checked && cboLop.SelectedItem != null)
            {
                string lop = cboLop.SelectedItem.ToString();
                query = query.Where(s => s.Lop == lop);
            }

            // Tìm theo môn học
            if (cbMonHoc.Checked && !string.IsNullOrWhiteSpace(txtMonHoc.Text))
            {
                string keyword = txtMonHoc.Text.Trim().ToLower();
                query = query.Where(s =>
                    s.MonHocDKy != null &&
                    s.MonHocDKy.Any(mh => mh.ToLower().Contains(keyword)));
            }

            var results = query.ToList();
            OnSearchCompleted?.Invoke(results);

            this.Close();
        }
    }
}
