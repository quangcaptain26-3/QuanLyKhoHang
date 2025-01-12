using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class FrmKhoHang : Form
    {
        public FrmKhoHang()
        {
            InitializeComponent();
            LoadDgv();
            LoadCbb();
        }

        private void LoadDgv()
        {
            dgv_load.DataSource = Database.Query("select * from KhoHang");
            btnSua.Enabled = btnXoa.Enabled = dgv_load.Rows.Count > 0;
        }

        private void LoadCbb()
        {
            cbbMaNV.DataSource = Database.Query("select * from KhoHang");
            cbbMaNV.ValueMember = "MaNhanVienPhuTrach";
            cbbMaNV.DisplayMember = "MaNhanVienPhuTrach";
        }

        private bool Check()
        {
            bool check = true;
            erp_loi.Clear();
            if (String.IsNullOrEmpty(txtId.Text))
            {
                erp_loi.SetError(txtId, "ID khong duoc de trong");
                check = false;
            }
            if (String.IsNullOrEmpty(txtName.Text))
            {
                erp_loi.SetError(txtName, "Ten khong duoc de trong");
                check = false;
            }
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                erp_loi.SetError(txtAddress, "Dia chi khong duoc de trong");
                check = false;
            }
            return check;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(Check() == false)
            {
                return;
            }
            string sql = "EXEC ThemKhoHang @MaKhoHang, @TenKhoHang, @DiaChi, @MaNhanVienPhuTrach";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@MaKhoHang", txtId.Text);
            dictionary.Add("@TenKhoHang", txtName.Text);
            dictionary.Add("@DiaChi", txtAddress.Text);
            dictionary.Add("MaNhanVienPhuTrach", cbbMaNV.SelectedValue);
            try
            {
                Database.Execute(sql, dictionary);
                LoadDgv();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }
            string sql = "EXEC SuaKhoHang @MaKhoHang, @TenKhoHang, @DiaChi, @MaNhanVienPhuTrach";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@MaKhoHang", txtId.Text);
            dictionary.Add("@TenKhoHang", txtName.Text);
            dictionary.Add("@DiaChi", txtAddress.Text);
            dictionary.Add("MaNhanVienPhuTrach", cbbMaNV.SelectedValue);
            try
            {
                Database.Execute(sql, dictionary);
                LoadDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "EXEC XoaKhoHang @MaKhoHang";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@MaKhoHang", txtId.Text);
            try
            {
                DialogResult result = MessageBox.Show("Co chac muon xoa khong", "Thong Bao", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    Database.Execute(sql, dictionary);
                    LoadDgv();
                    txtId.Text = txtName.Text = txtAddress.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_load_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgv_load.Rows[e.RowIndex].Cells["colMaKhoHang"].Value.ToString();
            txtName.Text = dgv_load.Rows[e.RowIndex].Cells["colTenKhoHang"].Value.ToString();
            txtAddress.Text = dgv_load.Rows[e.RowIndex].Cells["colDiaChi"].Value.ToString();
            cbbMaNV.SelectedValue = dgv_load.Rows[e.RowIndex].Cells["colMaNhanVienPhuTrach"].Value.ToString();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string sql = "select * from TimKiemKhoHang(@TuKhoa)";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            if (cbFind.Checked)
            {
                dictionary.Add("@TuKhoa", txtFind.Text);
            }
            else
            {
                dictionary.Add("@TuKhoa", DBNull.Value);
            }
                dgv_load.DataSource = Database.Query(sql, dictionary);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                return;
            }
            if(
                txtId.Text.Length >= 3
                || char.IsPunctuation(e.KeyChar)
                || char.IsWhiteSpace(e.KeyChar)
                || !char.IsLetterOrDigit(e.KeyChar)
                )
            {
                e.Handled = true;
            }
        }
    }
}
