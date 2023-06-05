using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
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
            TestClick = new RelayCommand<object>(ExecuteMybuton, CanMyButon);
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
            return param.ToString().Equals("ABC")? true : false;
        }

        void ExecuteMybuton(object param)
        {
            MessageBox.Show(param.ToString() + "AAA");
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
