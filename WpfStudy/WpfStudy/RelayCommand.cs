using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfStudy
{
    class RelayCommand<T> : ICommand
    {
        // 속성, 생성자에게만 값을 할당하도록 해줌
        readonly Action<T> _execute; 
        readonly Predicate<T> _canexecute;

        // 함수를 위임할 수 있고, return 값이 없는 Action을 사용함.
        // action과 비슷한 하나의 parameter와 return값으로 사용되는 bool type인 predicate 사용

        /*
        Action에 object대신 generic을 사용하는 이유
        generic type <T>는 int, string, cutomer등 다양한 타입에 대한 커맨드를 생성할 수 있기에
        여러타입에 대해 재사용이 가능하여 코드 중복을 피할 수 있음.
        */

        // 외부로 부터 받음 함수를 넣어줌
        public RelayCommand(Action<T> action, Predicate<T> predicate)
        {
            _execute = action;
            _canexecute = predicate;
        }

        // action만 외부로 부터 받음
        // action이 null일 때 즉 can Execute에 위임할 수가 없을때도 생성 가능
        public RelayCommand(Action<T> action) : this(action, null)
        {
        }

        public event EventHandler CanExecuteChanged
        {
            /*
            add는 WPF Command system에 연결
            canexcute의 결과에 영항을 줄수 있는 변경사항을 자동으로 인식
            */
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            /*
            _canexecute가 null로 할당 됐는지 check
            null일 경우 항상 return을 true로해서 항상 실행가능상태로하고
            그 외에는 _canExcute를 실행 
            */
            return _canexecute == null ? true : _canexecute((T)parameter);
        }

        public void Execute(object parameter)
        {
            // generic type (T) 으로 변경해서 호출함.
            _execute((T)parameter);
        }
    }
}
