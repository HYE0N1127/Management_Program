using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using ManageMent_Program.Model;
using ManageMent_Program.View;

namespace ManageMent_Program.ViewModel
{
    public class ManagerViewModel : BindableBase
    {
        #region Get, Set
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

        public ObservableCollection<Student> students = new ObservableCollection<Student>();

        #endregion

        #region 추가 커맨드
        public DelegateCommand StudentAddCommand { get; set; }
        public DelegateCommand StudentDeleteCommand { get; set; }

        public ManagerViewModel()
        {
            // 델리게이트를 이용하여 커맨드가 실행되면 두가지 함수가 실행되게 해주었습니다
            StudentAddCommand = new DelegateCommand(StudentAdd, CanAdd);
            StudentDeleteCommand = new DelegateCommand(StudentDelete, CanDelete);        
        }

        private void StudentAdd()
        {
            if (string.IsNullOrEmpty(_inputStudent.Name) && string.IsNullOrEmpty(_inputStudent.Department))
            {
                students.Add(new Student() { Name = _inputStudent.Name, Department = _inputStudent.Department });
            }
        }

        private bool CanAdd()
        {
            return _inputStudent != null;
        }

        private void StudentDelete()
        {
            students.Remove(SelectedStudent);
        }

        private bool CanDelete()
        {
            if(SelectedStudent != null)
            { 
                return true;
            }
            return false;
        }
        #endregion
    }
}

