using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using ManageMent_Program.Model;
using ManageMent_Program.View;

namespace ManageMent_Program.ViewModel
{
    public class ManagerViewModel : BindableBase
    {
        #region 학생 추가, 삭제
        
        public DelegateCommand StudentAddCommand { get; set; }

        public DelegateCommand StudentDeleteCommand { get; set; }

        #endregion  
    }
}

