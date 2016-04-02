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
        public FitB()
        {
            InitializeComponent();
        }
        int termNums;
        int a;

        private void txtFillInAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                KeyEvent();
            }
        }
        private void KeyEvent()
        {

            if (txtFillInAnswer.Text == AssignmentList.getAssignment().GetList(a, 0))
            {
                lblCorrect.Content = "Correct";
                lblCorrect.Background = Brushes.Green;
            }
            else
            {
                lblCorrect.Content = "Incorrect. Try Again";
                lblCorrect.Background = Brushes.Red;
            }

        }

        private void btnStartGame_Click(object sender, RoutedEventArgs e)
        {
            //randomly assign a definition
            Random rnd = new Random();
            a = rnd.Next(0, termNums);
            txtblkDefinition.Text = AssignmentList.getAssignment().GetList(a, 1);
            txtFillInAnswer.Text = "";
            lblCorrect.Content = "";
            lblCorrect.Background = Brushes.White;
            btnStartGame.Content = "Next Question";


        }
        private void Window_Closed(object sender, EventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            termNums = 0;
            for (int i = 0; i < 40; i++)
            {
                if (AssignmentList.getAssignment().GetList(i, 0) != "")
                {
                    termNums++;
                }
            }
            for (int i = 0; i < termNums; i++)
            {
                menuWindow.termList.Items.Add(AssignmentList.getAssignment().GetList(i, 0));
            }
        }
    }
}
