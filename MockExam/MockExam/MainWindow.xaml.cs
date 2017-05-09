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

namespace MockExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            hideAll();
        }

        private void hideAll()
        {
            if (radioOne.IsChecked == true)
            {
                RAW.Visibility = Visibility.Visible;
                Smackdown.Visibility = Visibility.Hidden;
                TLC.Visibility = Visibility.Hidden;
                TotalDivas.Visibility = Visibility.Hidden;
            }

            else if (radioTwo.IsChecked == true)
            {
                Smackdown.Visibility = Visibility.Visible;
                RAW.Visibility = Visibility.Hidden;
                TLC.Visibility = Visibility.Hidden;
                TotalDivas.Visibility = Visibility.Hidden;
            }

            else if (radioThree.IsChecked == true)
            {
                TLC.Visibility = Visibility.Visible;
                RAW.Visibility = Visibility.Hidden;
                Smackdown.Visibility = Visibility.Hidden;
                TotalDivas.Visibility = Visibility.Hidden;
            }

            else if (radioFour.IsChecked == true)
            {
                TotalDivas.Visibility = Visibility.Visible;
                RAW.Visibility = Visibility.Hidden;
                Smackdown.Visibility = Visibility.Hidden;
                TLC.Visibility = Visibility.Hidden;
            }

            else
            {
                RAW.Visibility = Visibility.Hidden;
                Smackdown.Visibility = Visibility.Hidden;
                TLC.Visibility = Visibility.Hidden;
                TotalDivas.Visibility = Visibility.Hidden;
            }
        }

        private void radioOne_Checked(object sender, RoutedEventArgs e)
        {
            hideAll();
        }

        private void radioTwo_Checked(object sender, RoutedEventArgs e)
        {
            hideAll();
        }

        private void radioThree_Checked(object sender, RoutedEventArgs e)
        {
            hideAll();
        }

        private void radioFour_Checked(object sender, RoutedEventArgs e)
        {
            hideAll();
        }

        private void checkInput_Click(object sender, RoutedEventArgs e)
        {
            int text;
            text = Int32.Parse(inputBox.Text);

            if (text < 1 || text > 50)
            {
                resultLabel.Content = "Out of Range";
            }

            else if (text < 25)
            {
                resultLabel.Content = "Too Low";
            }

            else if (text > 25)
            {
                resultLabel.Content = "Too High";
            }

            else if (text == 25)
            {
                resultLabel.Content = "You Found It!";
            }
        }

        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            int color = comboBox.SelectedIndex + 1;

            switch(color)
            {
                case 1:
                    MessageBox.Show("Your choose Red");
                    break;
                case 2:
                    MessageBox.Show("Your choose Blue");
                    break;
                case 3:
                    MessageBox.Show("Your choose Green");
                    break;
            }
        }
    }
}
