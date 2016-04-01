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
        public MultipleChoice()
        {
            InitializeComponent();
        }
        public string[] setAnswers()
        {
            termNums = 0;
            for (int i = 0; i < 40; i++)
            {
                if (Assignment.GetList(i, 0) != null)
                {
                    termNums++;
                }
            }
            Random rnd = new Random();
            string[] answers;
            int a = rnd.Next(0, termNums--);
            txtblkDefinition.Text = Assignment.GetList(a, 1);
            correctAnswer = Assignment.getList(a, 0);
            termNums++;
            int b = GiveMeANumber(a, a, a);
            int c = GiveMeANumber(a, b, b);
            int d = GiveMeANumber(a, b, c);
            answers = new string[4] { correctAnswer, Assignment.GetList(b, 0), Assignment.GetList(c, 0), Assignment.GetList(d, 0)};
            string[] rndTemp = answers.OrderBy(x => rnd.Next()).ToArray();
            return rndTemp;
        }
        private int GiveMeANumber(int a, int b, int c)
        {
            var exclude = new HashSet<int>() {a,b,c};
            var range = Enumerable.Range(0, termNums--).Where(i => !exclude.Contains(i));

            var rand = new System.Random();
            int index = rand.Next(0, termNums - exclude.Count);
            termNums++;
            return range.ElementAt(index);
        }
        public string defintion;
        public string term1;
        public string term2;
        public string term3;
        public string term4;
        public string correctAnswer;
        string[] currentProblem = new string[4];
        int termNums;


        //start game button
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            currentProblem = setAnswers();
            string[] rndAnswers = currentProblem.OrderBy(x => rnd.Next()).ToArray();
            btnTerm1.Content = rndAnswers[0];
            btnTerm2.Content = rndAnswers[1];
            btnTerm3.Content = rndAnswers[2];
            btnTerm4.Content = rndAnswers[3];
            ResetTheButtons();
        }

        private void btnTerm1_Click(object sender, RoutedEventArgs e)
        {
            Button answer = (Button)sender;
            if ((string)answer.Content == correctAnswer) 
            {
                answer.Background = Brushes.PaleGreen;
                //switch questions                                         
            }
            else
            {
                answer.Background = Brushes.Red;

            } 
        }
        private void ResetTheButtons()
        {
            btnTerm1.Background = Brushes.White;
            btnTerm2.Background = Brushes.White;
            btnTerm3.Background = Brushes.White;
            btnTerm4.Background = Brushes.White;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            int termNums = 0;
            for (int i = 0; i < 40; i++)
            {
                if (Assignment.GetList(i, 0) != "")
                {
                    termNums++;
                }
            }
            for (int i = 0; i < termNums; i++)
            {
                menuWindow.termList.Items.Add(Assignment.GetList(i, 0));
            }
        }
    }
}
