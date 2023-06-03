using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfStudy.Models;

namespace WpfStudy
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTest1_Click(object sender, RoutedEventArgs e)
        {
            List<User> myList1 = new List<User>();
            labelTest1.Content = "내용변경완료";
            MessageBox.Show(textBox1.Text);

            User userA = new User();
            userA.Name = "Noah";
            userA.UsersAge = 15;

            User userB = new User();
            userB.Name = "Liam";
            userB.UsersAge = 15;

            myList1.Add(userA);
            myList1.Add(userB);


        }


    }
}
