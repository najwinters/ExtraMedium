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

        List<Question> listOQuestions = new List<Question>();
        bool isTerm = false;
        int currentIndex = 0;
        int MAX_ASSIGNMENTS = AssignmentList.getAssignment().getTotal();


        public Flashcards()
        {
            InitializeComponent();
            for (int i = 0; i < MAX_ASSIGNMENTS; i++)
            {
                Assignment question = AssignmentList.getAssignment(i);
                Question q = new Question(question.GetList(i, 0), question.GetList(i, 1));
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
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            currentIndex++;
            isTerm = true;
            //go to the next definition
            if(currentIndex == MAX_ASSIGNMENTS)
            {
                currentIndex = 0;
            }
            btnFlashCard_Click(new object(), new RoutedEventArgs());

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            //go back to the previous definition
            currentIndex--;
            isTerm = true;
            //go to the next definition
            if (currentIndex == 0)
            {
                currentIndex = MAX_ASSIGNMENTS-1;
            }
            btnFlashCard_Click(new object(), new RoutedEventArgs());
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
