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
using System.Windows.Shapes;
using System.Threading;

namespace DiatonicOctopotato
{
    /// <summary>
    /// Interaction logic for MultipleChoice.xaml
    /// </summary>
    public partial class MultipleChoice : Window
    {
        public int score = 0;
        //int currentIndex = 0;
       // int MAX_TERMS = AssignmentList.getAssignment().getTotal();
        public MultipleChoice()
        {
            InitializeComponent();
           btnTerm1.IsEnabled = false;
           btnTerm2.IsEnabled = false;
           btnTerm3.IsEnabled = false;
           btnTerm4.IsEnabled = false;
        }
        public string[] setAnswers()
        {
                /*Assignment currentAssignment = AssignmentList.getAssignment();
                List<Question> listOQuestions = new List<Question>();
                for (int i = 0; i < MAX_TERMS; i++)
                {

                    Question q = new Question(currentAssignment.GetList(i, 0), currentAssignment.GetList(i, 1));
                    listOQuestions.Add(q);
                }*/
                Random rnd = new Random();
                string[] answers;
                int z = AssignmentList.getAssignment().getTotal();
                int a = rnd.Next(0, z--);
                txtblkDefinition.Text = AssignmentList.getAssignment().GetList(a, 1);
                correctAnswer = AssignmentList.getAssignment().getList(a, 0);
                int b = GiveMeANumber(a, a, a);
                int c = GiveMeANumber(a, b, b);
                int d = GiveMeANumber(a, b, c);
                answers = new string[4] { correctAnswer, AssignmentList.getAssignment().GetList(b, 0), AssignmentList.getAssignment().GetList(c, 0), AssignmentList.getAssignment().GetList(d, 0) };
                string[] rndTemp = answers.OrderBy(x => rnd.Next()).ToArray();
                return rndTemp;
            
        }
        private int GiveMeANumber(int a, int b, int c)
        {
            var excludedNumbers = new List<int> {a, b, c};
            int z = AssignmentList.getAssignment().getTotal();
            Random rnd = new Random();

            int number;

            do
            {
                number = rnd.Next(0, z-1);
            } while (excludedNumbers.Contains(number));
            return number;
        }
        public string defintion;
        public string term1;
        public string term2;
        public string term3;
        public string term4;
        public string correctAnswer;
        string[] currentProblem = new string[4];


        //start game button
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (AssignmentList.getAssignment().getTotal() < 4)
            {
                MessageBox.Show("You must have four or more terms before using this feature!");
                this.Close();
            }
            else
            {
                button.Content = "Next Question";
                btnTerm1.IsEnabled = true;
                btnTerm2.IsEnabled = true;
                btnTerm3.IsEnabled = true;
                btnTerm4.IsEnabled = true;

                Random rnd = new Random();
                currentProblem = setAnswers();
                string[] rndAnswers = currentProblem.OrderBy(x => rnd.Next()).ToArray();
                btnTerm1.Content = rndAnswers[0];
                btnTerm2.Content = rndAnswers[1];
                btnTerm3.Content = rndAnswers[2];
                btnTerm4.Content = rndAnswers[3];
                ResetTheButtons();
                button.IsEnabled = false;
                lblScore.Content = score;
            }
        }

        private void btnTerm1_Click(object sender, RoutedEventArgs e)
        {
            Button answer = (Button)sender;
            if ((string)answer.Content == correctAnswer) 
            {
                //answer.Background = Brushes.PaleGreen;
                lblCorrect.Background = Brushes.Green;
                lblCorrect.Content = "Correct!!";
                button.IsEnabled = true;
                score++;
                lblScore.Content = score;
                btnTerm1.IsEnabled = false;
                btnTerm2.IsEnabled = false;
                btnTerm3.IsEnabled = false;
                btnTerm4.IsEnabled = false;
            }
            else
            {
                //answer.Background = Brushes.Red;
                lblCorrect.Background = Brushes.Red;
                lblCorrect.Content = "Incorrect, Try Again :(";
                score--;
                lblScore.Content = score;

            } 
        }
        private void ResetTheButtons()
        {
            btnTerm1.Background = Brushes.White;
            btnTerm2.Background = Brushes.White;
            btnTerm3.Background = Brushes.White;
            btnTerm4.Background = Brushes.White;
            lblCorrect.Background = Brushes.White;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Analytics.mCReport(score);
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            menu.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Management m = new Management();
            m.Show();
            this.Close();
        }
    }
}
