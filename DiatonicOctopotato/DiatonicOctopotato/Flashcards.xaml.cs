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
    /// Interaction logic for Flashcards.xaml
    /// </summary>
    public partial class Flashcards : Window
    {
        int score = 0;
        int tryCount = 0;
        List<Question> listOQuestions = new List<Question>();
        bool isTerm = false;
        int currentIndex = 0;
        int MAX_TERMS = AssignmentList.getAssignment().getTotal();
        bool backClicked = false;
        bool nextClicked = false;
        bool rightClicked = false;
        bool wrongClicked = false;
        


        public Flashcards()
        {
            Assignment currentAssignment = AssignmentList.getAssignment();
            InitializeComponent();
            btnBack.IsEnabled = false;
            btnNext.IsEnabled = false;
            for (int i = 0; i < MAX_TERMS; i++) 
            {
                
                Question q = new Question(currentAssignment.GetList(i, 0), currentAssignment.GetList(i, 1));
                listOQuestions.Add(q);
            }
            btnFlashCard.Content = listOQuestions[currentIndex].definition;

        }

        private void btnFlashCard_Click(object sender, RoutedEventArgs e)
        {
            //switch between term and definition
            if (isTerm)
            {
                //switch to def 
                btnFlashCard.Content = listOQuestions[currentIndex].definition;
                //reverse isTerm
                isTerm = !isTerm;
            }
            else
            {
                //switch to term
                btnFlashCard.Content = listOQuestions[currentIndex].term;
                //reverse isTerm
                isTerm = !isTerm;
            }
            if (isTerm)
            {
                //switch to def 
                flashcardText.Text = listOQuestions[currentIndex].definition;
                //reverse isTerm
                isTerm = !isTerm;
            }
            else
            {
                //switch to term
                flashcardText.Text = listOQuestions[currentIndex].term;
                //reverse isTerm
                isTerm = !isTerm;
            }
             
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {

            //tryCount++;
            nextClicked = true;
            currentIndex++;
            isTerm = true;
            //go to the next definition
            if(currentIndex == MAX_TERMS)
            {
                currentIndex = 0;
            }
            btnFlashCard_Click(new object(), new RoutedEventArgs());
            CheckScore();
            btnBack.IsEnabled = false;
            btnNext.IsEnabled = false;

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            
            backClicked = true;
            //tryCount--;
            //go back to the previous definition
            currentIndex--;
            isTerm = true;
            //go to the next definition
            if (currentIndex == -1)
            {
                currentIndex = MAX_TERMS-1;
            }
            btnFlashCard_Click(new object(), new RoutedEventArgs());
            CheckScore();
            btnBack.IsEnabled = false;
            btnNext.IsEnabled = false;
        }
        private void Flashcards1_Closed(object sender, EventArgs e)
        {

        }

        private void Flashcards1_Closed_1(object sender, EventArgs e)
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

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            rightClicked = true;
            //score++;
            
            btnBack.IsEnabled = true;
            btnNext.IsEnabled = true;
            CheckScore();
        }

        private void btnWrong_Click(object sender, RoutedEventArgs e)
        {
            wrongClicked = true;
            //score--;
           
            btnBack.IsEnabled = true;
            btnNext.IsEnabled = true;
            CheckScore();
        }
        private void CheckScore()
        {
            if(backClicked && rightClicked)
            {
                tryCount--;
                backClicked = false;
                rightClicked = false;
                lblScore.Content = score;
                lblTryCount.Content = tryCount;
            }
            if(backClicked && wrongClicked)
            {
                tryCount--;
                backClicked = false;
                wrongClicked = false;
                lblScore.Content = score;
                lblTryCount.Content = tryCount;
            }
            if(nextClicked && rightClicked)
            {
                tryCount++;
                score++;
                rightClicked = false;
                nextClicked = false;
                lblScore.Content = score;
                lblTryCount.Content = tryCount;
            }
            if(nextClicked && wrongClicked)
            {
                tryCount++;
                score--;
                nextClicked = false;
                wrongClicked = false;
                lblScore.Content = score;
                lblTryCount.Content = tryCount;
            }
            if(tryCount == 15)
            {
                this.Close();
            }

        }

        private void analyticsBTN_Click(object sender, RoutedEventArgs e)
        {
            AnalyticsPage aPage = new AnalyticsPage();
            aPage.Show();
            this.Close();
            
        }
    }
    public class Question
    {
        public string term { get; set; }
        public string definition { get; set; }

        public Question() { }
        public Question(string _term, string _def)
        {
            term = _term;
            definition = _def;
        }
    }
}
