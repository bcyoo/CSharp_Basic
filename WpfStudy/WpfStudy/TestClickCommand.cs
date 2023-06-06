using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfStudy.ViewModels;

namespace WpfStudy
{
    class TestClickCommand : ICommand // ex: RelayCommand, DelegateCommand, RoutedCommand .....
    {
        private MainViewModel _mainViewModel;
        private bool rtnCan = true;

        // CanExecute() 실행을 호출하는 이벤트 발생, 외부 이벤트 구독 가능
        // WPF Command System 연결 위해 사용
        public event EventHandler CanExecuteChanged; 

        public TestClickCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        // Command 활성화, 비활성화 제어
        // True return command 활성화
        public bool CanExecute(object parameter) 
        {
            return rtnCan;
            //throw new NotImplementedException();
        }

        // Command가 호출 됐을 때 실행
        public void Execute(object parameter) 
        {
            MessageBox.Show(_mainViewModel.ProgressValue+"");
            //throw new NotImplementedException();
        }
    }
}
