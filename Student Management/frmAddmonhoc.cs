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
    public partial class frmAddmonhoc : Form
    {
        public string TenMH { get; private set; }
        public frmAddmonhoc()
        {
            InitializeComponent();
            this.AcceptButton = btnAdd;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TenMH = txtTenmh.Text.Trim();
            if (string.IsNullOrWhiteSpace(TenMH))
            {
                MessageBox.Show("Tên môn học không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
