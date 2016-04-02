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

namespace DiatonicOctopotato
{
    /// <summary>
    /// Interaction logic for FitB.xaml
    /// </summary>
    public partial class FitB : Window
    {
        int termNums = AssignmentList.getAssignment().getTotal();
        public int score = 0;
       /* public string[] setAnswers()
        {
            
            Random rnd = new Random();
            string[] answers;
            int a = rnd.Next(0, termNums--);
            txtblkDefinition.Text = AssignmentList.getAssignment().GetList(a, 1);
            correctAnswer = AssignmentList.getAssignment().getList(a, 0);
            termNums++;
            int b = GiveMeANumber(a, a, a);
            int c = GiveMeANumber(a, b, b);
            int d = GiveMeANumber(a, b, c);
            answers = new string[4] { correctAnswer, AssignmentList.getAssignment().GetList(b, 0), AssignmentList.getAssignment().GetList(c, 0), AssignmentList.getAssignment().GetList(d, 0) };
            string[] rndTemp = answers.OrderBy(x => rnd.Next()).ToArray();
            return rndTemp;

        }*/
        private int GiveMeANumber(int a, int b, int c)
        {
            ;       var exclude = new HashSet<int>() { a, b, c };
            var range = Enumerable.Range(0, termNums--).Where(i => !exclude.Contains(i));
            var rand = new System.Random();
            int index = rand.Next(0, termNums - exclude.Count);
            termNums++;
            return range.ElementAt(index);
        }
        public FitB()
        {
            InitializeComponent();
            if (AssignmentList.getAssignment().getTotal() == 0)
            {
                MessageBox.Show("Sorry, you need to have terms in your assignment!");
                MenuWindow menuWindow = new MenuWindow();
                menuWindow.Show();

            }
        }
        int a;
        public string correctAnswer;


        private void txtFillInAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                KeyEvent();
            }
        }
        private void KeyEvent()
        {


            if (txtFillInAnswer.Text.ToLower().Equals(correctAnswer))  //AssignmentList.getAssignment().GetList(a, 0))

            {
                score++;
                lblCorrect.Content = "Correct!!";
                lblCorrect.Background = Brushes.Green;
                txtFillInAnswer.IsEnabled = false;
                btnNextGame.IsEnabled = true;
                lblScore.Content = score;
            }
            else
            {
                score--;
                lblCorrect.Content = "Incorrect. Try Again";
                lblCorrect.Background = Brushes.Red;
                lblScore.Content = score;


            }

        }

        private void btnStartGame_Click(object sender, RoutedEventArgs e)
        {
            //randomly assign a definition
            btnStartGame.Visibility = Visibility.Hidden;
            txtFillInAnswer.IsEnabled = true;
            Random rnd = new Random();
            a = rnd.Next(0, AssignmentList.getAssignment().getTotal());
            txtblkDefinition.Text = AssignmentList.getAssignment().GetList(a, 1);
            correctAnswer = AssignmentList.getAssignment().GetList(a, 0);

            txtFillInAnswer.Text = "";
            lblCorrect.Content = "";
            lblCorrect.Background = Brushes.White;
            btnNextGame.Visibility = Visibility.Visible;
            btnNextGame.IsEnabled = false;


        }
        private void Window_Closed(object sender, EventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            if (AssignmentList.getAssignment().getTotal() < 4)
            {
                menuWindow.Show();
            }
            else
            {
                menuWindow.Show();
            }
        }

        private void btnNextGame_Click(object sender, RoutedEventArgs e)
        {
            btnStartGame.Visibility = Visibility.Hidden;
            txtFillInAnswer.IsEnabled = true;
            Random rnd = new Random();
            a = rnd.Next(0, AssignmentList.getAssignment().getTotal());
            txtblkDefinition.Text = AssignmentList.getAssignment().GetList(a, 1);
            correctAnswer = AssignmentList.getAssignment().GetList(a, 0);
            txtFillInAnswer.Text = "";
            lblCorrect.Content = "";
            lblCorrect.Background = Brushes.White;
            btnNextGame.Visibility = Visibility.Visible;
            btnNextGame.IsEnabled = false;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow w = new MenuWindow();
            w.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Management m = new Management();
            m.Show();
            this.Close();
        }
    }
}
