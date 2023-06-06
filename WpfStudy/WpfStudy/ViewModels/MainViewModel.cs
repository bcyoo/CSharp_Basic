using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfStudy.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        private int progressValue;

        public ICommand TestClick { get; set; }
        public MainViewModel()
        {
            //TestClick = new RelayCommand<object>(ExecuteMybuton, CanMyButon);
            TestClick = new AsyncRelayCommand(ExecuteMyButton2);
            //Task t = ExecuteMyButton2();
        }

        public int ProgressValue
        {
            get { return progressValue; }
            set { 
                progressValue = value;
                NotifyPropertyChanged(nameof(ProgressValue));
            }
        }

        bool CanMyButon(object param)
        {
            if (param == null)
            {
                return true;
            }
            // TextBox 값이 ABC면 True
            return param.ToString().Equals("ABC")? true : false;
        }

        void ExecuteMybuton(object param)
        {
            //MessageBox.Show(param.ToString() + "AAA");

            int w = 0;
            Task task1 = Task.Run(() =>
            {
                for (int i = 0; i < 10; ++i)
                {
                    ProgressValue = i;
                }
            });

            Task rtn2 = Task.Run(() =>
            {
                for ( int i = 0; i < 50; ++i)
                {
                    ProgressValue = i;
                    w = i;
                    Thread.Sleep(2000); // 2초마다 for문 횟수만큼 thread를 대기상태로 만듬
                }
            });

            //rtn2.Wait();
            MessageBox.Show(w + "");
        }

        /*
        async 사용하면 비동기 메소드를 의미
        Task와 같은 awaitable 클래스의 객체가 완료되기를 기다리는  
        await 키워들 사용할 수 있음
        
        async 작성된 비동기 메소드 장점은
        앞서 ExcuteMybutton에서 wait함수를 호출했으나
        이 경우 작업이 오래걸릴 경우 UI Thrad도 같이 멈추게 됨.
        */
        public async Task ExecuteMyButton2()
        {
            int w = 0;
      
            Task<int> rtn2 = Task.Run(() => 
            {
                for (int i = 0; i < 50; ++i)
                {
                    ProgressValue = i;
                    w = i;
                    Thread.Sleep(2000);
                }
                int j = 6;
                return j;
            });

            w = await rtn2;
            MessageBox.Show(w + "");
        }

        


        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional PropertyNAme
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String PropertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
