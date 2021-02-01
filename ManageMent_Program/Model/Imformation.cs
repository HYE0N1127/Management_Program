using Prism.Mvvm;

namespace ManageMent_Program.Model
{
    public class Student : BindableBase
        // public class Student : INotifyPropertyChanged
        {
            private string _firstName;
            public string FirstName
            {
                get => _firstName;

                set
                {
                    SetProperty(ref _firstName, value);

                    //_firstName = value;
                    //NotifyPropertyChanged(nameof(FirstName));
                }
            }

            private string _department;
            public string Department
            {
                get 
                { 
                    return _department;
                }

                set
                {
                    SetProperty(ref _department, value);
                }
            }

            public string StudentImformation
            {
                get
                {
                    return _firstName + " " + _department;
                }
            }

        }
    }