using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using ManageMent_Program.Model;
using ManageMent_Program.View;

namespace ManageMent_Program.ViewModel
{
    public class ManagerViewModel : BindableBase
    {
        private string _inputStudent;
        public string InputStudent
        {
            get => _inputStudent;
            set => SetProperty(ref _inputStudent, value);
        }

        private string _selectedStudent;

        public string SelectedStudent
        {
            get => _selectedStudent;
            set => SetProperty(ref _selectedStudent, value);
        }


    }
}

