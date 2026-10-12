
namespace QuanLySinhVien
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel panelThongTin;
        private System.Windows.Forms.Panel panelDanhSach;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.Label lblTong;

        private System.Windows.Forms.TableLayoutPanel tableThongTin;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblAvatar;

        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.TextBox txtAvatarPath;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.PictureBox picAvatar;

        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXuatCSV;

        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.panelDanhSach = new System.Windows.Forms.Panel();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();

            this.tableThongTin = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblAvatar = new System.Windows.Forms.Label();

            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.txtAvatarPath = new System.Windows.Forms.TextBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();

            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXuatCSV = new System.Windows.Forms.Button();

            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.colMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.panelHeader.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.panelThongTin.SuspendLayout();
            this.panelDanhSach.SuspendLayout();
            this.tableThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(244, 247, 251);
            this.ClientSize = new System.Drawing.Size(1180, 740);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 4.6 - Quản lý sinh viên";
            this.Font = new System.Drawing.Font("Segoe UI", 10F);

            // Header
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.panelHeader.Controls.Add(this.lblTieuDe);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1180, 78);
            this.panelHeader.TabIndex = 0;

            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Text = "HỆ THỐNG QUẢN LÝ SINH VIÊN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Main layout
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.mainLayout.Controls.Add(this.panelThongTin, 0, 0);
            this.mainLayout.Controls.Add(this.panelDanhSach, 1, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Padding = new System.Windows.Forms.Padding(12);
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.TabIndex = 1;

            // Left panel
            this.panelThongTin.BackColor = System.Drawing.Color.White;
            this.panelThongTin.Controls.Add(this.tableThongTin);
            this.panelThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThongTin.Padding = new System.Windows.Forms.Padding(12);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.TabIndex = 0;

            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblThongTin.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblThongTin.Text = "THÔNG TIN SINH VIÊN";
            this.lblThongTin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);

            // Input table
            this.tableThongTin.ColumnCount = 1;
            this.tableThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableThongTin.Controls.Add(this.lblThongTin, 0, 0);
            this.tableThongTin.Controls.Add(this.lblMaSV, 0, 1);
            this.tableThongTin.Controls.Add(this.txtMaSV, 0, 2);
            this.tableThongTin.Controls.Add(this.lblHoTen, 0, 3);
            this.tableThongTin.Controls.Add(this.txtHoTen, 0, 4);
            this.tableThongTin.Controls.Add(this.lblTuoi, 0, 5);
            this.tableThongTin.Controls.Add(this.txtTuoi, 0, 6);
            this.tableThongTin.Controls.Add(this.lblGioiTinh, 0, 7);
            this.tableThongTin.Controls.Add(this.cboGioiTinh, 0, 8);
            this.tableThongTin.Controls.Add(this.lblAvatar, 0, 9);
            this.tableThongTin.Controls.Add(this.picAvatar, 0, 10);
            this.tableThongTin.Controls.Add(this.txtAvatarPath, 0, 11);
            this.tableThongTin.Controls.Add(this.btnChonAnh, 0, 12);
            this.tableThongTin.Controls.Add(this.btnThem, 0, 13);
            this.tableThongTin.Controls.Add(this.btnXoa, 0, 14);
            this.tableThongTin.Controls.Add(this.btnCapNhat, 0, 15);
            this.tableThongTin.Controls.Add(this.btnXuatCSV, 0, 16);
            this.tableThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableThongTin.AutoScroll = true;
            this.tableThongTin.Name = "tableThongTin";
            this.tableThongTin.RowCount = 17;
            this.tableThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));

            // Labels
            this.lblMaSV.Text = "Mã sinh viên";
            this.lblHoTen.Text = "Họ và tên";
            this.lblTuoi.Text = "Tuổi";
            this.lblGioiTinh.Text = "Giới tính";
            this.lblAvatar.Text = "Ảnh đại diện";
            System.Windows.Forms.Label[] labels = {
                this.lblMaSV, this.lblHoTen, this.lblTuoi,
                this.lblGioiTinh, this.lblAvatar
            };

            foreach (System.Windows.Forms.Label label in labels)
            {
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                label.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
                label.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
            }

            // TextBoxes
            this.txtMaSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaSV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 4);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.TabIndex = 0;

            this.txtHoTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.TabIndex = 1;

            this.txtTuoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTuoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTuoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 4);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.TabIndex = 2;

            this.cboGioiTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 4);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.TabIndex = 3;

            // Avatar
            this.picAvatar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picAvatar.BackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(82, 323);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(150, 140);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 4;
            this.picAvatar.TabStop = false;

            this.txtAvatarPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAvatarPath.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtAvatarPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 4);
            this.txtAvatarPath.Name = "txtAvatarPath";
            this.txtAvatarPath.ReadOnly = true;
            this.txtAvatarPath.TabIndex = 5;

            // Buttons
            this.btnChonAnh.Text = "CHỌN ẢNH AVATAR";
            this.btnThem.Text = "THÊM";
            this.btnXoa.Text = "XÓA";
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnXuatCSV.Text = "XUẤT CSV";

            System.Windows.Forms.Button[] buttons = {
                this.btnChonAnh, this.btnThem, this.btnXoa,
                this.btnCapNhat, this.btnXuatCSV
            };

            foreach (System.Windows.Forms.Button button in buttons)
            {
                button.Dock = System.Windows.Forms.DockStyle.Fill;
                button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                button.ForeColor = System.Drawing.Color.White;
                button.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
                button.UseVisualStyleBackColor = false;
            }

            this.btnChonAnh.BackColor = System.Drawing.Color.FromArgb(78, 99, 120);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.TabIndex = 6;

            this.btnThem.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnThem.Name = "btnThem";
            this.btnThem.TabIndex = 7;

            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TabIndex = 8;

            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.TabIndex = 9;

            this.btnXuatCSV.BackColor = System.Drawing.Color.FromArgb(142, 68, 173);
            this.btnXuatCSV.Name = "btnXuatCSV";
            this.btnXuatCSV.TabIndex = 10;

            // Right panel
            this.panelDanhSach.BackColor = System.Drawing.Color.White;
            this.panelDanhSach.Controls.Add(this.dgvSinhVien);
            this.panelDanhSach.Controls.Add(this.lblTong);
            this.panelDanhSach.Controls.Add(this.lblDanhSach);
            this.panelDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDanhSach.Padding = new System.Windows.Forms.Padding(12);
            this.panelDanhSach.Name = "panelDanhSach";
            this.panelDanhSach.TabIndex = 1;

            this.lblDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDanhSach.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblDanhSach.Height = 42;
            this.lblDanhSach.Text = "DANH SÁCH SINH VIÊN";
            this.lblDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblTong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTong.ForeColor = System.Drawing.Color.Gray;
            this.lblTong.Height = 28;
            this.lblTong.Text = "Tổng: 0 sinh viên";
            this.lblTong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // DataGridView
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.AutoGenerateColumns = false;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSinhVien.ColumnHeadersHeight = 42;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMaSV, this.colHoTen, this.colTuoi, this.colGioiTinh
            });
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinhVien.EnableHeadersVisualStyles = false;
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.RowTemplate.Height = 34;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.TabIndex = 0;

            this.dgvSinhVien.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.dgvSinhVien.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSinhVien.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvSinhVien.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvSinhVien.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(242, 246, 250);

            this.colMaSV.DataPropertyName = "StudentId";
            this.colMaSV.HeaderText = "Mã SV";
            this.colMaSV.Name = "colMaSV";
            this.colMaSV.ReadOnly = true;
            this.colMaSV.FillWeight = 22F;

            this.colHoTen.DataPropertyName = "FullName";
            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            this.colHoTen.FillWeight = 38F;

            this.colTuoi.DataPropertyName = "Age";
            this.colTuoi.HeaderText = "Tuổi";
            this.colTuoi.Name = "colTuoi";
            this.colTuoi.ReadOnly = true;
            this.colTuoi.FillWeight = 15F;

            this.colGioiTinh.DataPropertyName = "Gender";
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            this.colGioiTinh.FillWeight = 20F;

            // Add controls to form
            this.Controls.Add(this.mainLayout);
            this.Controls.Add(this.panelHeader);

            this.panelHeader.ResumeLayout(false);
            this.mainLayout.ResumeLayout(false);
            this.panelThongTin.ResumeLayout(false);
            this.panelDanhSach.ResumeLayout(false);
            this.tableThongTin.ResumeLayout(false);
            this.tableThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
