
using System.ComponentModel;

namespace QuanLySinhVien
{
    public class Student : INotifyPropertyChanged
    {
        private string studentId = "";
        private string fullName = "";
        private int age;
        private string gender = "Nam";
        private string avatarPath = "";

        public event PropertyChangedEventHandler PropertyChanged;

        private void ThongBaoThayDoi(string tenThuocTinh)
        {
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(tenThuocTinh));
        }

        public string StudentId
        {
            get { return studentId; }
            set
            {
                if (studentId != value)
                {
                    studentId = value;
                    ThongBaoThayDoi(nameof(StudentId));
                }
            }
        }

        public string FullName
        {
            get { return fullName; }
            set
            {
                if (fullName != value)
                {
                    fullName = value;
                    ThongBaoThayDoi(nameof(FullName));
                }
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (age != value)
                {
                    age = value;
                    ThongBaoThayDoi(nameof(Age));
                }
            }
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                if (gender != value)
                {
                    gender = value;
                    ThongBaoThayDoi(nameof(Gender));
                }
            }
        }

        public string AvatarPath
        {
            get { return avatarPath; }
            set
            {
                if (avatarPath != value)
                {
                    avatarPath = value;
                    ThongBaoThayDoi(nameof(AvatarPath));
                }
            }
        }
    }
}
