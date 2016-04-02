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

        private void Window_Closed(object sender, EventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
        }

        private void txtFillInAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                KeyEvent();
            }
        }
        private void KeyEvent()
        {
            if(txtFillInAnswer.Text == "Mammal")
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
            txtblkDefinition.Text = "What is a pig";
            txtFillInAnswer.Text = "";
            lblCorrect.Content = "";
            lblCorrect.Background = Brushes.White;
            btnStartGame.Content = "New Game";


        }
    }
}
