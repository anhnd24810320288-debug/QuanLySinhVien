
using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        private BindingList<Student> danhSach;
        private BindingSource bindingSource;

        private bool dangThem = false;
        private Student sinhVienMoi;

        public Form1()
        {
            InitializeComponent();

            KhoiTaoDuLieu();
            CauHinhBinding();

            btnThem.Click += BtnThem_Click;
            btnXoa.Click += BtnXoa_Click;
            btnCapNhat.Click += BtnCapNhat_Click;
            btnChonAnh.Click += BtnChonAnh_Click;
            btnXuatCSV.Click += BtnXuatCSV_Click;

            dgvSinhVien.SelectionChanged +=
                DgvSinhVien_SelectionChanged;

            bindingSource.CurrentChanged +=
                BindingSource_CurrentChanged;

            this.FormClosed += Form1_FormClosed;
        }

        private void KhoiTaoDuLieu()
        {
            danhSach = new BindingList<Student>();

            danhSach.Add(new Student
            {
                StudentId = "SV001",
                FullName = "Nguyễn Văn An",
                Age = 20,
                Gender = "Nam",
                AvatarPath = ""
            });

            danhSach.Add(new Student
            {
                StudentId = "SV002",
                FullName = "Trần Thị Bình",
                Age = 21,
                Gender = "Nữ",
                AvatarPath = ""
            });

            danhSach.Add(new Student
            {
                StudentId = "SV003",
                FullName = "Lê Minh Hoàng",
                Age = 19,
                Gender = "Nam",
                AvatarPath = ""
            });

            bindingSource = new BindingSource();
            bindingSource.DataSource = danhSach;

            bindingSource.ListChanged += (s, e) =>
            {
                lblTong.Text =
                    "Tổng: " + danhSach.Count + " sinh viên";
            };

            lblTong.Text =
                "Tổng: " + danhSach.Count + " sinh viên";
        }

        private void CauHinhBinding()
        {
            dgvSinhVien.DataSource = bindingSource;

            txtMaSV.DataBindings.Add(
                "Text",
                bindingSource,
                "StudentId",
                true,
                DataSourceUpdateMode.Never);

            txtHoTen.DataBindings.Add(
                "Text",
                bindingSource,
                "FullName",
                true,
                DataSourceUpdateMode.Never);

            txtTuoi.DataBindings.Add(
                "Text",
                bindingSource,
                "Age",
                true,
                DataSourceUpdateMode.Never);

            cboGioiTinh.DataBindings.Add(
                "Text",
                bindingSource,
                "Gender",
                true,
                DataSourceUpdateMode.Never);

            txtAvatarPath.DataBindings.Add(
                "Text",
                bindingSource,
                "AvatarPath",
                true,
                DataSourceUpdateMode.Never);

            if (danhSach.Count > 0)
                bindingSource.Position = 0;

            HienThiAvatar();
        }

        private void BindingSource_CurrentChanged(
            object sender, EventArgs e)
        {
            if (!dangThem)
                HienThiAvatar();
        }

        private void DgvSinhVien_SelectionChanged(
            object sender, EventArgs e)
        {
            if (!dangThem)
                HienThiAvatar();
        }

        private void HienThiAvatar()
        {
            if (picAvatar.Image != null)
            {
                Image anhCu = picAvatar.Image;
                picAvatar.Image = null;
                anhCu.Dispose();
            }

            string duongDan = txtAvatarPath.Text;

            if (string.IsNullOrWhiteSpace(duongDan))
                return;

            if (!File.Exists(duongDan))
                return;

            try
            {
                using (FileStream fs = new FileStream(
                    duongDan,
                    FileMode.Open,
                    FileAccess.Read))
                {
                    using (Image anh = Image.FromStream(fs))
                    {
                        picAvatar.Image = new Bitmap(anh);
                    }
                }
            }
            catch
            {
                picAvatar.Image = null;
            }
        }

        private void XoaBinding()
        {
            txtMaSV.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtTuoi.DataBindings.Clear();
            cboGioiTinh.DataBindings.Clear();
            txtAvatarPath.DataBindings.Clear();
        }

        private void TaoLaiBinding()
        {
            XoaBinding();
            CauHinhBinding();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (!dangThem)
            {
                BatDauThem();
                return;
            }

            if (!KiemTraDuLieu(null))
                return;

            GanDuLieu(sinhVienMoi);

            Student sv = sinhVienMoi;

            danhSach.Add(sv);

            dangThem = false;
            sinhVienMoi = null;

            btnThem.Text = "THÊM";
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;

            TaoLaiBinding();

            bindingSource.Position = danhSach.IndexOf(sv);

            MessageBox.Show(
                "Thêm sinh viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BatDauThem()
        {
            dangThem = true;

            sinhVienMoi = new Student
            {
                StudentId = "",
                FullName = "",
                Age = 18,
                Gender = "Nam",
                AvatarPath = ""
            };

            XoaBinding();

            txtMaSV.Clear();
            txtHoTen.Clear();
            txtTuoi.Text = "18";
            cboGioiTinh.SelectedIndex = 0;
            txtAvatarPath.Clear();

            XoaAnh();

            btnThem.Text = "LƯU THÊM";
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;

            dgvSinhVien.ClearSelection();
            txtMaSV.Focus();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            Student sv = bindingSource.Current as Student;

            if (sv == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên " +
                sv.FullName + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                bindingSource.RemoveCurrent();

                if (danhSach.Count > 0)
                    bindingSource.Position = 0;
                else
                    XoaAnh();

                MessageBox.Show("Xóa sinh viên thành công!");
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            Student sv = bindingSource.Current as Student;

            if (sv == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần cập nhật!");
                return;
            }

            if (!KiemTraDuLieu(sv))
                return;

            GanDuLieu(sv);
            bindingSource.ResetCurrentItem();

            HienThiAvatar();

            MessageBox.Show(
                "Cập nhật sinh viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private bool KiemTraDuLieu(Student dangSua)
        {
            string ma = txtMaSV.Text.Trim();
            string ten = txtHoTen.Text.Trim();

            if (ma == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!");
                txtMaSV.Focus();
                return false;
            }

            if (ten == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                txtHoTen.Focus();
                return false;
            }

            int tuoi;

            if (!int.TryParse(txtTuoi.Text.Trim(), out tuoi)
                || tuoi < 16 || tuoi > 100)
            {
                MessageBox.Show("Tuổi phải từ 16 đến 100!");
                txtTuoi.Focus();
                return false;
            }

            if (cboGioiTinh.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return false;
            }

            foreach (Student sv in danhSach)
            {
                if (sv != dangSua &&
                    string.Equals(
                        sv.StudentId,
                        ma,
                        StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!");
                    txtMaSV.Focus();
                    return false;
                }
            }

            return true;
        }

        private void GanDuLieu(Student sv)
        {
            sv.StudentId = txtMaSV.Text.Trim();
            sv.FullName = txtHoTen.Text.Trim();
            sv.Age = int.Parse(txtTuoi.Text.Trim());
            sv.Gender = cboGioiTinh.Text;
            sv.AvatarPath = txtAvatarPath.Text;
        }

        private void BtnChonAnh_Click(object sender, EventArgs e)
        {
            if (!dangThem && bindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên trước!");
                return;
            }

            using (OpenFileDialog hopThoai = new OpenFileDialog())
            {
                hopThoai.Title = "Chọn ảnh đại diện";
                hopThoai.Filter =
                    "Ảnh đại diện (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (hopThoai.ShowDialog() != DialogResult.OK)
                    return;

                txtAvatarPath.Text = hopThoai.FileName;

                HienThiAvatar();

                if (!dangThem)
                {
                    Student sv = bindingSource.Current as Student;

                    if (sv != null)
                    {
                        sv.AvatarPath = hopThoai.FileName;
                        bindingSource.ResetCurrentItem();
                    }
                }
            }
        }

        private void XoaAnh()
        {
            if (picAvatar.Image != null)
            {
                Image anhCu = picAvatar.Image;
                picAvatar.Image = null;
                anhCu.Dispose();
            }
        }

        private string XuLyCSV(string giaTri)
        {
            if (giaTri == null)
                giaTri = "";

            giaTri = giaTri.Replace("\"", "\"\"");

            if (giaTri.Contains(",") ||
                giaTri.Contains("\"") ||
                giaTri.Contains("\r") ||
                giaTri.Contains("\n"))
            {
                giaTri = "\"" + giaTri + "\"";
            }

            return giaTri;
        }

        private void BtnXuatCSV_Click(object sender, EventArgs e)
        {
            if (danhSach.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên đang trống!");
                return;
            }

            using (SaveFileDialog hopThoai = new SaveFileDialog())
            {
                hopThoai.Title = "Xuất danh sách sinh viên";
                hopThoai.Filter = "CSV (*.csv)|*.csv";
                hopThoai.FileName = "DanhSachSinhVien.csv";
                hopThoai.DefaultExt = "csv";
                hopThoai.AddExtension = true;
                hopThoai.OverwritePrompt = true;

                if (hopThoai.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (StreamWriter sw = new StreamWriter(
                        hopThoai.FileName,
                        false,
                        new UTF8Encoding(true)))
                    {
                        sw.WriteLine(
                            "StudentId,FullName,Age,Gender,AvatarPath");

                        foreach (Student sv in danhSach)
                        {
                            sw.WriteLine(
                                XuLyCSV(sv.StudentId) + "," +
                                XuLyCSV(sv.FullName) + "," +
                                sv.Age + "," +
                                XuLyCSV(sv.Gender) + "," +
                                XuLyCSV(sv.AvatarPath));
                        }
                    }

                    MessageBox.Show(
                        "Xuất file CSV thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Không thể xuất file: " + ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            XoaAnh();
        }
    }
}
