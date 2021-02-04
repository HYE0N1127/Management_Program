using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ManageMent_Program.Model;
using ManageMent_Program.View;

namespace ManageMent_Program.ViewModel
{
    public class ManagerViewModel : BindableBase
    {
        #region 학생 추가, 학생 삭제
      // Delegate 사용 이유 : 코드의 재활용, 함수를 실행하기 위함.
        public DelegateCommand StudentAddCommand { get; set; }
        public DelegateCommand StudentDeleteCommand {get; set;}

        #endregion

        #region MainWindow 값
        MainWindow mainwindow = new MainWindow();


        #endregion
    }
}
