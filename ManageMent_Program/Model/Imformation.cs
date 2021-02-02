using Prism.Mvvm;

namespace ManageMent_Program.Model
{
    public class Student : BindableBase
        {
            private string _name;
            public string Name
            {
                get => _name;

                set
                {
                SetProperty(ref _name, value);
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
                    return _name + " " + _department;
                }
            }
        }
    }