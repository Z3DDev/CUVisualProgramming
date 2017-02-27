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

namespace SimpleCalculator
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

        String currentNum = "";
        int firstNum = 0;
        Boolean second = false;


        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            currentNum += "1";

            if (!second)
                textbox1.Text = currentNum;
            else
                textbox2.Text = currentNum;
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            currentNum += "2";

            if (!second)
                textbox1.Text = currentNum;
            else
                textbox2.Text = currentNum;
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            firstNum = Int32.Parse(currentNum);
            second = true;
            currentNum = "";
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            int answer = firstNum + Int32.Parse(currentNum);
            answerBox.Text = answer.ToString();
        }
    }
}
