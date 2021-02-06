﻿using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using ManageMent_Program.Model;
using ManageMent_Program.View;

namespace ManageMent_Program.ViewModel
{
    public class ManagerViewModel : BindableBase
    {
        #region Get, Set
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
        #endregion

        #region List

        public ObservableCollection<Student> student
        {
            get;
            set;
        }

        #endregion

        #region
        public DelegateCommand StudentAddCommand { get; set; }
        public DelegateCommand StudentDeleteCommand { get; set; }

        public ManagerViewModel()
        {
            //StudentAddCommand = new DelegateCommand(StudentAdd, CanAdd);
            //StudentDeleteCommand = new DelegateCommand(StudentDelete, CanDelete);        
        }
        #endregion
    }
}

