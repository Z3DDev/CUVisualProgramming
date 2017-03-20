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

namespace Assign3Jagod
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

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            double correct = 0;
            double incorrect = 0;
            double avgScore = 0;
            bool qOne = false;
            bool qTwo = false;
            bool qThree = false;
            bool qFour = false;
            bool qFive = false;
            bool qSix = false;
            bool qSeven = false;
            bool qEight = false;

            while (qOne == false)
            {
                if (captainTwo.IsChecked.Value == true)
                {
                    correct++;
                    qOne = true;
                }
                else
                {
                    incorrect++;
                    q1.Foreground = new SolidColorBrush(Colors.Red);
                    break;
                }
            }
            
            while (qTwo == false)
            {
                if (antOne.IsChecked.Value == true)
                {
                    correct++;
                    qTwo = true;
                }
                else
                {
                    incorrect++;
                    q2.Foreground = new SolidColorBrush(Colors.Red);
                    break;
                }
            }
            /*
            while (qThree == false)
            {
                //Creates an Array of Correct Answers
                CheckBox[] galaxyAnswers = new CheckBox[] { galaxyOne, galaxyThree, galaxyFour, galaxyFive };

                if (galaxyTwo.IsChecked.Value == true)
                {
                    //If the Incorrect Answer was listed, Incorrect Answer will be triggered instead
                    incorrect++;
                    break;
                }

                else if (galaxyTwo.IsChecked.Value == false)
                {
                    foreach (CheckBox gA in galaxyAnswers)
                    {
                        double tempcorrect = 0;

                        if (gA.IsChecked.Value == true)
                        {
                            //Because there are four correct answers, 0.25 points will be awarded for each part correct
                            //It is possible to miss a correct answer!
                            tempcorrect += 0.25;

                            if (tempcorrect == 1)
                            {
                                MessageBox.Show("Question Three: Correct");
                                correct++;
                                qThree = true;
                            }
                            else
                                continue;
                        }
                        else
                            break;
                    }
                }
                else
                    break;
            }
            /*
            while (qFour == false)
            {
                //Creates an Array of Correct Answers
                CheckBox[] civilAnswers = new CheckBox[] { civilOne, civilTwo, civilThree, civilFour };

                if (civilFive.IsChecked.Value == true)
                {
                    //If the Incorrect Answer was listed, Incorrect Answer will be triggered instead
                    incorrect++;
                }

                else
                {
                    foreach (CheckBox cA in civilAnswers)
                    {
                        double tempcorrect = 0;

                        if (cA.IsChecked.Value == true)
                        {
                            //Because there are four correct answers, 0.25 points will be awarded for each part correct
                            //It is possible to miss a correct answer!
                            tempcorrect += 0.25;
                        }

                        else if (tempcorrect == 1)
                        {
                            correct++;
                            qFour = true;
                        }

                        else
                            break;
                    }
                }
            }
            */
            while (qFive == false)
            {
                if (comboTony.SelectedIndex == 0)
                {
                    correct++;
                    qFive = true;
                }
                else
                {
                    incorrect++;
                    q5.Foreground = new SolidColorBrush(Colors.Red);
                    break;
                }

            }

            while (qSix == false)
            {
                if (comboGems.SelectedIndex == 4)
                {
                    correct++;
                    qSix = true;
                }
                else
                {
                    incorrect++;
                    q6.Foreground = new SolidColorBrush(Colors.Red);
                    break;
                }
            }

            while (qSeven == false)
            {
                string aDead;
                aDead = txtboxOne.Text.ToLower();

                if (aDead == "deadpool")
                {
                    correct++;
                    qSeven = true;
                }
                else
                {
                    incorrect++;
                    q7.Foreground = new SolidColorBrush(Colors.Red);
                    break;
                }
            }

            while (qEight == false)
            {
                string aHawk;
                aHawk = txtboxTwo.Text.ToLower();

                if (aHawk == "hawkeye")
                {
                    correct++;
                    qEight = true;
                }
                else
                {
                    incorrect++;
                    q7.Foreground = new SolidColorBrush(Colors.Red);
                    break;
                }
            }
            //Calculates the users average score from current round
            avgScore = (correct / 8) * 100;

            //If and only if the user gets all the questions correct
            if(correct == 8)
            {
                MessageBox.Show("Congratulations! You Aced the Quiz!" + Environment.NewLine + "Correct: " + correct + Environment.NewLine +
                                "Incorrect: " + incorrect + Environment.NewLine + "Score: " + avgScore + "%");
            }

            //If the user did not get 100% on the quiz
            else
            {
                MessageBox.Show("Correct: " + correct + Environment.NewLine + "Incorrect: " + incorrect + 
                                Environment.NewLine + "All incorrectly answered questions have been highlighted in red" + Environment.NewLine +
                                "Average Score: " + avgScore + "%");
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            //Clear all Multiple Choice
            RadioButton[] radioAnswer = new RadioButton[] { captainOne, captainTwo, captainThree, captainFour, antOne, antTwo, antThree, antFour };

            foreach (RadioButton rb in radioAnswer)
            {
                rb.IsChecked = false;
            }

            //Clear all Multiple Answer
            CheckBox[] multAnswer = new CheckBox[] { galaxyOne, galaxyTwo, galaxyThree, galaxyFour, galaxyFive, civilOne, civilTwo, civilThree, civilFour, civilFive };

            foreach (Control c in multAnswer)
            {
                ((CheckBox)c).IsChecked = false;
            }

            //Clear all Combo Box
            comboTony.SelectedIndex = -1;
            comboGems.SelectedIndex = -1;

            //Clear all Fill-In-The-Blank
            txtboxOne.Text = String.Empty;
            txtboxTwo.Text = String.Empty;

            //Display to the user that all answers have been cleared
            MessageBox.Show("Your Answers Have Been Cleared");
        }
    }
}