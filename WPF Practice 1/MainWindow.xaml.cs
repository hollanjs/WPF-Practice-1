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
using System.Threading;

namespace WPF_Practice_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string name = "Josh Hollandsworth";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;

            myLabel.Text = $"Name: {name}\nx: {x}\nd: {d}";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 5;

            if (x == 10)
            {
                myLabel.Text = "x is definitely 10!";
            }
            else
            {
                myLabel.Text = "x is definitely NOT 10!";
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 4;
            string name = "John Hollingsworth";

            if ((someValue == 3) && (name == "Josh Hollandsworth"))
            {
                myLabel.Text = $"x is 3 and the name is {name}";
            }

            myLabel.Text = "This line runs no matter what";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            // figure out later how to implement thread sleep in wpf app
            int count = 0;

            myLabel.Text = "Starting While Loop to count up ^";
            //Thread.Sleep(1000);

            while (count < 10)
            {
                myLabel.Text = $"Count is currently: {count}";
                count += 1;
                //Thread.Sleep(1000);
            }

            myLabel.Text = "Starting For Loop with subtraction -";
            //Thread.Sleep(1000);

            for (int i = 0; i < 5; i++)
            {
                myLabel.Text = $"Count is currently: {count}";
                count = count - 1;
                //Thread.Sleep(1000);
            }

            myLabel.Text = $"And finally, the count settles at: {count}";
        }
    }
}
