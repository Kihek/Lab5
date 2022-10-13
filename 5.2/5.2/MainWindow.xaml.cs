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

namespace _5._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Lift elevator;
        public MainWindow()
        {
            InitializeComponent();
            elevator = new Lift(1,1,cur_floor_tb);
        }

        private void Close_btn_Click(object sender, RoutedEventArgs e)
        {
            close_btn.IsEnabled = false;
            im_doors.Visibility = Visibility.Hidden;
            open_btn.IsEnabled = true;
            elevator.dveri = Lift.doors.Closed;
        }

        private void Open_btn_Click(object sender, RoutedEventArgs e)
        {
            if(elevator.apd == Lift.upd.NotGo)
            {
                open_btn.IsEnabled = false;
                im_doors.Visibility = Visibility.Visible;
                close_btn.IsEnabled = true;
                elevator.dveri = Lift.doors.Open;
            }

        }

        private void Go_btn_Click(object sender, RoutedEventArgs e)
        {
            if (elevator.dveri == Lift.doors.Closed)
            {
                elevator.timer_call(Convert.ToInt32(cur_floor_tb.Text), Convert.ToInt32(floor_tb.Text));
            }
        }
    }
}
