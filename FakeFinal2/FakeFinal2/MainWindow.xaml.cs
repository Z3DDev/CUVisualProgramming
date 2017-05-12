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

namespace FakeFinal2
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

        private void celebrateButton_Click(object sender, RoutedEventArgs e)
        {
            if ((eventOne.IsChecked == true) && (accessoryOne.IsChecked == true))
            {
                textBlock.Text = "NYC with Fireworks";
            }

            else if ((eventTwo.IsChecked == true) && (accessoryOne.IsChecked == true))
            {
                textBlock.Text = "House Party with Fireworks";
            }

            else if ((eventOne.IsChecked == true) && (accessoryTwo.IsChecked == true))
            {
                textBlock.Text = "NYC with Food";
            }

            else if ((eventTwo.IsChecked == true) && (accessoryTwo.IsChecked == true))
            {
                textBlock.Text = "House Party with Food";
            }

            else if ((eventOne.IsChecked == false) || (eventTwo.IsChecked == false) && (accessoryOne.IsChecked == true))
            {
                textBlock.Text = "No Event selection with Fireworks";
            }

            else if ((eventOne.IsChecked == false) || (eventTwo.IsChecked == false) && (accessoryTwo.IsChecked == true))
            {
                textBlock.Text = "No Event selection with Food";
            }

            else if ((accessoryOne.IsChecked == false) || (accessoryTwo.IsChecked == false) && (eventOne.IsChecked == true))
            {
                textBlock.Text = "No Accessory selection with NYC";
            }

            else if ((accessoryOne.IsChecked == false) || (accessoryTwo.IsChecked == false) && (eventTwo.IsChecked == true))
            {
                textBlock.Text = "No Accessory selection with House Party";
            }

            else
                textBlock.Text = "No Selections Made";
        }

        private void gameButton_Click(object sender, RoutedEventArgs e)
        {
            if (gameBoxOne.Text == gameBoxTwo.Text)
            {
                resultLabel.Content = "Numbers must be Unique";
            }

            else if (((gameBoxOne.Text == "1") || (gameBoxOne.Text == "2")) && ((gameBoxTwo.Text == "1") || (gameBoxTwo.Text == "2")))
            {
                resultLabel.Content = "Winning Number 1 : found \n Winning Number 2 : found";
            }

            else if ((gameBoxOne.Text == "1") || (gameBoxTwo.Text == "1"))
            {
                resultLabel.Content = "Winning Number 1 : found";
            }

            else if ((gameBoxOne.Text == "2") || (gameBoxTwo.Text == "2"))
            {
                resultLabel.Content = "Winning Number 2 : found";
            }

            else
                resultLabel.Content = "No Match!";
        }

        private void holidayButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Happy Holidays");
        }
    }
}
