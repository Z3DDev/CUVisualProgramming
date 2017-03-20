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
            double correct = 0; //Setup to count # of correct answers
            double incorrect = 0; //Setup to count # of incorrect answers
            double avgScore = 0; //Setup to later calculate the average score (8 total questions)

            //Booleans set to false in order for while loops to run, each loop contains If and Else statements 
            //(occasionally an Else If statement)
            bool qOne = false; bool qTwo = false; bool qThree = false; bool qFour = false;
            bool qFive = false; bool qSix = false; bool qSeven = false; bool qEight = false;

            while (qOne == false)
            {
                //Checks for value of designated answer
                if (captainTwo.IsChecked.Value == true)
                {
                    correct++; //+1 to the correct counter
                    qOne = true; //Sets the Boolean value to True, and ends the While Loop
                }

                //If anything but designated answer is returned, assumed to be incorrect
                else
                {
                    incorrect++; //+1 to the incorrect counter
                    q1.Foreground = new SolidColorBrush(Colors.Red); //If question was incorrect, changes label color to red to signify it was answered wrong
                    break; //removes self from current loop to begin next while loop for the next question
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
            
            while (qThree == false)
            {
                //If the Incorrect Answer was listed, Incorrect Answer will be triggered instead
                if (galaxyTwo.IsChecked.Value == true)
                {
                    incorrect++;
                    q3.Foreground = new SolidColorBrush(Colors.Red);
                    break;
                }
                /*
                else if (galaxyTwo.IsChecked.Value == false)
                {
                    //Creates an Array of Correct Answers
                    CheckBox[] galaxyAnswers = new CheckBox[] { galaxyOne, galaxyThree, galaxyFour, galaxyFive };

                    foreach (CheckBox gA in galaxyAnswers)
                    {
                        double tempcorrect = 0;

                        while (gA.IsChecked.Value == true)
                        {
                            //Because there are four correct answers, 0.25 points will be awarded for each part correct
                            //It is possible to miss a correct answer!
                            tempcorrect = tempcorrect + 0.25;
                        }

                        if (tempcorrect == 1)
                        {
                            correct++;
                            qThree = true;
                        }
                        else if (tempcorrect <= 0.75)
                        {
                            MessageBox.Show("Partially Correct - Did you get ALL of the members?");
                            incorrect++;
                            q3.Foreground = new SolidColorBrush(Colors.Red);
                            break;
                        }
                        else
                            break;
                    }
                    
                }*/
                else
                {
                    correct++;
                    qThree = true;
                }
            }
            
            while (qFour == false)
            {
                if (civilFive.IsChecked.Value == true)
                {
                    //If the Incorrect Answer was listed, Incorrect Answer will be triggered instead
                    incorrect++;
                    q4.Foreground = new SolidColorBrush(Colors.Red);
                    break;
                }
                /*
                else if(civilFive.IsChecked.Value == false)
                {
                    //Creates an Array of Correct Answers
                    CheckBox[] civilAnswers = new CheckBox[] { civilOne, civilTwo, civilThree, civilFour };

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
                }*/
                else
                {
                    correct++;
                    qFour = true;
                }
            }
            
            while (qFive == false)
            {
                //Checks the Selected Index for correct answer
                if (comboTony.SelectedIndex == 0)
                {
                    correct++;
                    qFive = true;
                }

                //If anything other than the specified index is selected, answer is incorrect
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
                string aDead; //Creates a new string for taking in the user written text
                aDead = txtboxOne.Text.ToLower(); //Sets the input equal to the new string, from the selected textBox, and sets it all to lower case

                //Checks for correct, written answer (no typos allowed)
                if (aDead == "deadpool")
                {
                    correct++;
                    qSeven = true;
                }

                //If answer was written incorrectly, or just incorrect
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

                //Reset all Boolean Values
                qOne = false; qTwo = false; qThree = false; qFour = false;
                qFive = false; qSix = false; qSeven = false; qEight = false;
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