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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            this.Hide();
            menuWindow.Show();           
        }

        private void inputListBN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tBDef.Text = AssignmentList.getAssignment().getList((termList.SelectedIndex), 1);
        }
        public void doLB() {
            int termNums = 0;
            for (int i = 0; i < 40; i++)
            {
                if (AssignmentList.getAssignment().GetList(i, 0) != "") {
                    termNums++;
                }
            }
            for (int i = 0; i < termNums; i++) {
                termList.Items.Add(AssignmentList.getAssignment().GetList(i, 0));
            }
        }

        private void fBBN_Click(object sender, RoutedEventArgs e)
        {
            FitB fITB = new FitB();
            fITB.Show();
            this.Hide();
        }
    }
}
