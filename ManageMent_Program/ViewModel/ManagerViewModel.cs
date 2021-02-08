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
            //StudentAddCommand = new DelegateCommand(StudentAdd, CanAdd);
            //StudentDeleteCommand = new DelegateCommand(StudentDelete, CanDelete);        
        }

        private void StudentAdd()
        {
            students.Add(new Student() { Name = _inputStudent.Name });
            // 부서 부분을 추가해야 합니다!
            // 데이터 바인딩 이후 추가 예정 -> 콤보박스 바인딩
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
             return true;
        }
        #endregion

    }
}

