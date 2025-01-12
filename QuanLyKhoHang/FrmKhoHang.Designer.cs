namespace QuanLyKhoHang
{
    partial class FrmKhoHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbFind = new System.Windows.Forms.CheckBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgv_load = new System.Windows.Forms.DataGridView();
            this.colMaKhoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNhanVienPhuTrach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erp_loi = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_loi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.txtFind);
            this.groupBox1.Controls.Add(this.cbFind);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 724);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tim Kiem";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbMaNV);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(357, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(923, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thong Tin";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Location = new System.Drawing.Point(357, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(923, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chuc Nang";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_load);
            this.groupBox4.Location = new System.Drawing.Point(357, 327);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(923, 409);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Du Lieu";
            // 
            // cbFind
            // 
            this.cbFind.AutoSize = true;
            this.cbFind.Location = new System.Drawing.Point(18, 39);
            this.cbFind.Name = "cbFind";
            this.cbFind.Size = new System.Drawing.Size(89, 22);
            this.cbFind.TabIndex = 0;
            this.cbFind.Text = "TimKiem";
            this.cbFind.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(18, 67);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(234, 24);
            this.txtFind.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(18, 117);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(233, 42);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "TimKiem";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(18, 165);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(233, 42);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(19, 213);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(233, 42);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaKhoHang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "TenKhoHang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "DiaChi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "MaNhanVienPhuTrach";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(199, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(234, 24);
            this.txtId.TabIndex = 5;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(199, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 24);
            this.txtName.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(199, 97);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(234, 24);
            this.txtAddress.TabIndex = 7;
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.DisplayMember = "MaNhanVienPhuTrach";
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(199, 133);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(231, 26);
            this.cbbMaNV.TabIndex = 8;
            this.cbbMaNV.ValueMember = "MaNhanVienPhuTrach";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 47);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Them";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(156, 20);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(125, 47);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(305, 20);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 47);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgv_load
            // 
            this.dgv_load.AllowUserToAddRows = false;
            this.dgv_load.AllowUserToDeleteRows = false;
            this.dgv_load.AllowUserToResizeColumns = false;
            this.dgv_load.AllowUserToResizeRows = false;
            this.dgv_load.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_load.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKhoHang,
            this.colTenKhoHang,
            this.colDiaChi,
            this.colMaNhanVienPhuTrach});
            this.dgv_load.Location = new System.Drawing.Point(11, 20);
            this.dgv_load.Name = "dgv_load";
            this.dgv_load.ReadOnly = true;
            this.dgv_load.RowHeadersWidth = 51;
            this.dgv_load.RowTemplate.Height = 24;
            this.dgv_load.Size = new System.Drawing.Size(898, 376);
            this.dgv_load.TabIndex = 0;
            this.dgv_load.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_load_RowEnter);
            // 
            // colMaKhoHang
            // 
            this.colMaKhoHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colMaKhoHang.DataPropertyName = "MaKhoHang";
            this.colMaKhoHang.HeaderText = "MaKhoHang";
            this.colMaKhoHang.MinimumWidth = 6;
            this.colMaKhoHang.Name = "colMaKhoHang";
            this.colMaKhoHang.ReadOnly = true;
            this.colMaKhoHang.Width = 120;
            // 
            // colTenKhoHang
            // 
            this.colTenKhoHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colTenKhoHang.DataPropertyName = "TenKhoHang";
            this.colTenKhoHang.HeaderText = "TenKhoHang";
            this.colTenKhoHang.MinimumWidth = 6;
            this.colTenKhoHang.Name = "colTenKhoHang";
            this.colTenKhoHang.ReadOnly = true;
            this.colTenKhoHang.Width = 124;
            // 
            // colDiaChi
            // 
            this.colDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "DiaChi";
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            // 
            // colMaNhanVienPhuTrach
            // 
            this.colMaNhanVienPhuTrach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colMaNhanVienPhuTrach.DataPropertyName = "MaNhanVienPhuTrach";
            this.colMaNhanVienPhuTrach.HeaderText = "MaNhanVienPhuTrach";
            this.colMaNhanVienPhuTrach.MinimumWidth = 6;
            this.colMaNhanVienPhuTrach.Name = "colMaNhanVienPhuTrach";
            this.colMaNhanVienPhuTrach.ReadOnly = true;
            this.colMaNhanVienPhuTrach.Width = 185;
            // 
            // erp_loi
            // 
            this.erp_loi.ContainerControl = this;
            // 
            // FrmKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 774);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmKhoHang";
            this.Text = "FrmKhoHang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_loi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.CheckBox cbFind;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgv_load;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhanVienPhuTrach;
        private System.Windows.Forms.ErrorProvider erp_loi;
    }
}