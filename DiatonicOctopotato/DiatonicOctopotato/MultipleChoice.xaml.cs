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
        public string defintion;
        public string term1;
        public string term2;
        public string term3;
        public string term4;
        public string correctAnswer = "Mammal";
        string[] currentProblem = new string[4];


        //start game button
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Random randy = new Random();
            currentProblem = new string[] { "Reptile", "Insect", "Mammal", "Amphibian" };//,"What is a Pig","Mammel","Animal Kingdom"};
            txtblkDefinition.Text = "What is a Pig?";
            string[] rndAnswers = currentProblem.OrderBy(x => randy.Next()).ToArray();
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
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
