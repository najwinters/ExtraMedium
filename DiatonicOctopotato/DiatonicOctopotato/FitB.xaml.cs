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
            if (AssignmentList.getAssignment().getTotal() == 0)
            {
                MessageBox.Show("Sorry, you need to have terms in your assignment!");
                MenuWindow menuWindow = new MenuWindow();
                menuWindow.Show();

            }
        }
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
                txtFillInAnswer.IsEnabled = false;
                btnNextGame.IsEnabled = true;
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
            btnStartGame.Visibility = Visibility.Hidden;
            txtFillInAnswer.IsEnabled = true;
            Random rnd = new Random();
            a = rnd.Next(0, AssignmentList.getAssignment().getTotal());
            txtblkDefinition.Text = AssignmentList.getAssignment().GetList(a, 1);
            txtFillInAnswer.Text = "";
            lblCorrect.Content = "";
            lblCorrect.Background = Brushes.White;
            btnNextGame.Visibility = Visibility.Visible;
            btnNextGame.IsEnabled = false;


        }
        private void Window_Closed(object sender, EventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
           
            for (int i = 0; i < AssignmentList.getAssignment().getTotal(); i++)
            {
                menuWindow.termList.Items.Add(AssignmentList.getAssignment().GetList(i, 0));
            }
        }

        private void btnNextGame_Click(object sender, RoutedEventArgs e)
        {
            btnStartGame.Visibility = Visibility.Hidden;
            txtFillInAnswer.IsEnabled = true;
            Random rnd = new Random();
            a = rnd.Next(0, AssignmentList.getAssignment().getTotal());
            txtblkDefinition.Text = AssignmentList.getAssignment().GetList(a, 1);
            txtFillInAnswer.Text = "";
            lblCorrect.Content = "";
            lblCorrect.Background = Brushes.White;
            btnNextGame.Visibility = Visibility.Visible;
            btnNextGame.IsEnabled = false;
        }
    }
}
