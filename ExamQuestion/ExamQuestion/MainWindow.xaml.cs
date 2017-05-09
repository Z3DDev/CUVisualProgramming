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

namespace ExamQuestion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Hides the final image at the start of the program
            after.Visibility = Visibility.Hidden;
        }

        private void tab1()
        {
            //creates an int for the switch statement, and adds 1 to the value of selectedindex due to starting at 0
            int option = movieBox.SelectedIndex + 1;

            switch (option)
            {
                case 1:
                    //Terminator
                    movieBlock.Text = "Action";
                    break;
                case 2:
                    //Tommy Boy
                    movieBlock.Text = "Comedy";
                    break;
                case 3:
                    //Titanic
                    movieBlock.Text = "Romance";
                    break;
            }

            //Extra Method (If Statement)
            /*
            if (movieBox.SelectedIndex == 0)
            {
                movieBlock.Text = "Action";
            }
            else if (movieBox.SelectedIndex == 1)
            {
                movieBlock.Text = "Comedy";
            }
            else if (movieBox.SelectedIndex == 2)
            {
                movieBlock.Text = "Romance";
            }
            */
        }

        private void tab2()
        {
            //String to contain the contents of the TextBox
            string text = foodBox.Text;

            //Each If/Else-If/Else Statement updates the label with the appropriate label content
            if (text == "beef")
            {
                foodLabel.Content = "meat";
            }
            else if (text == "cheese")
            {
                foodLabel.Content = "dairy";
            }
            else if (text == "apple")
            {
                foodLabel.Content = "fruit";
            }
            else
                foodLabel.Content = "other";
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            //Calls tab1 method
            tab1();
            //Calls tab2 method
            tab2();

            //Makes the sad image dissapear
            before.Visibility = Visibility.Hidden;
            //Makes the happy image appear
            after.Visibility = Visibility.Visible;
        }
    }
}
