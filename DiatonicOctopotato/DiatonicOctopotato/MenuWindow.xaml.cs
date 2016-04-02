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
            
        }
        int termNum;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window1 nTWin = new Window1();
            nTWin.Show();
           
        }

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

        private void inputListBN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tBDef.Text = AssignmentList.getAssignment().getList((termList.SelectedIndex), 1);
        }
        public void doLB()
        {
            
            for (int i = 0; i < AssignmentList.getAssignment().getTotal(); i++)
            {
                termList.Items.Add(AssignmentList.getAssignment().GetList(i, 0));
            }
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
    }
}

