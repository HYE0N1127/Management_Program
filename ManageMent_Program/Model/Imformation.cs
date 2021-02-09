using Prism.Mvvm;

namespace ManageMent_Program.Model
{
    public class Student : BindableBase
        {
        public enum DepartmentTeams
        {
            WINDOW,
            SERVER,
            WEB,
            ANDROID
        };

        // 언더바가 붙은 변수명은 무조건 private로 지정해주세요
            private string _name;
            public string Name
            {
            get
            {
                return _name;
            }
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
    }
}