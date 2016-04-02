using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DiatonicOctopotato
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {

        public MenuWindow()
        {
            InitializeComponent();
            if(AssignmentList.getAssignment() == null)
            {
                errorBlock.Visibility = Visibility.Visible;
            }
            else
            {
                errorBlock.Visibility = Visibility.Hidden;
            }
        }
        int termNum;

        private void OpenManagement_Click(object sender, RoutedEventArgs e)
        {
            Management ManageWindow = new Management();
            ManageWindow.Show();
            this.Hide();
        }

        private void mCBN_Click(object sender, RoutedEventArgs e)
        {
            MultipleChoice mCWin = new MultipleChoice();
            mCWin.Show();
            this.Hide();
        }

        private void fBBN_Click(object sender, RoutedEventArgs e)
        {
            FitB fITB = new FitB();
            fITB.Show();
            this.Hide();
        }
        private int getTermNum()
        {
            for (int i = 0; i < 40; i++)
            {
                if (AssignmentList.getAssignment().GetList(i, 0) != "")
                {
                    termNum++;
                }
            }
            return termNum;
        }

        private void btnFlashCards_Click(object sender, RoutedEventArgs e)
        {
            Flashcards fCWin = new Flashcards();
            fCWin.Show();
            this.Hide();
        }

        private void analyticsBTN_Click(object sender, RoutedEventArgs e)
        {
            AnalyticsPage aPage = new AnalyticsPage();
            aPage.Show();
            this.Hide();
        }

        private void homeBTN_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }

        private void mCBN_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void fBBN_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnFlashCards_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AnalyticsPage a = new AnalyticsPage();
            a.Show();
            this.Close();
        }
    }
}

