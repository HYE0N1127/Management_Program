using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using ManageMent_Program.Model;
using ManageMent_Program.View;
using System.Diagnostics;
using System.Windows;

namespace ManageMent_Program.ViewModel
{
    public class ManagerViewModel : BindableBase
    {
        #region Get, Set
        private string _studentName;

        public string StudentName
        {
            get => _studentName;
            set => SetProperty(ref _studentName, value);
        }

        private string _studentDepartment;

        public string StudentDepartment
        {
            get => _studentDepartment;
            set => SetProperty(ref _studentDepartment, value);
        }

        private Student _inputStudent = new Student();
        public Student InputStudent
        {
            get => _inputStudent;
            set => SetProperty(ref _inputStudent, value);
        }

        private Student _selectedStudent = new Student();

        public Student SelectedStudent
        {
            get => _selectedStudent;
            set => SetProperty(ref _selectedStudent, value);
        }
        #endregion

        #region List

        public ObservableCollection<Student> Students { get; set; }

        #endregion

        #region 추가 커맨드
        public DelegateCommand StudentAddCommand { get; set; }
        public DelegateCommand StudentDeleteCommand { get; set; }

        public ManagerViewModel()
        {
            // 델리게이트를 이용하여 커맨드가 실행되면 두가지 함수가 실행되게 해주었습니다
            StudentAddCommand = new DelegateCommand(StudentAdd, CanAdd);
            StudentDeleteCommand = new DelegateCommand(StudentDelete, CanDelete);

            Students = new ObservableCollection<Student>();
        }

        private void StudentAdd()
        {
            if (!string.IsNullOrEmpty(_studentName) && !string.IsNullOrEmpty(_studentDepartment))
            {
                Students.Add(new Student() { Name = _studentName, Department = _studentDepartment });
            }
            _studentName = "";
            _studentDepartment = "";
        }

        private bool CanAdd()
        {
            return _inputStudent != null;
        }

        private void StudentDelete()
        {
            Students.Remove(SelectedStudent);
        }

        private bool CanDelete()
        {
            if (SelectedStudent != null)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}

