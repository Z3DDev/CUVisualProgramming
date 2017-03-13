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

namespace Lecture8
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (checkBoxJM.IsChecked.Value == true)
            {
                MessageBox.Show("Correct");
            }
            else if (checkBoxTJ.IsChecked.Value == true)
            {
                MessageBox.Show("Incorrect");
            }
            else if (checkBoxDT.IsChecked.Value == true)
            {
                MessageBox.Show("Don't believe the Fake News");
            }

        }

        private void checkBoxJM_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
