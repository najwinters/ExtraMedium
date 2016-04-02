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
    /// Interaction logic for Management.xaml
    /// </summary>
    public partial class Management : Window
    {
        public Management()
        {
            InitializeComponent();
            loadAssignmentList();
        }

        private void loadAssignmentList()
        {
            int total = AssignmentList.getTotal();
            if (total > 0)
            {
                studyLists.Items.Clear();
                for (int i = 0; i < total; i++)
                {
                    studyLists.Items.Add(AssignmentList.getAssignment(i).getName());
                }
            }
        }

        private void newList_Click(object sender, System.EventArgs e)
        {
            NewAssignment nameWindow = new NewAssignment();
            nameWindow.Closed += newClosed;
            nameWindow.Show();
        }

        private void newClosed(object sender, System.EventArgs e)
        {
            loadAssignmentList();
        }

        private void studyLists_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AssignmentList.setAssignment(studyLists.SelectedIndex);
        }

        private void editTerms_Click(object sender, RoutedEventArgs e)
        {
            if (studyLists.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an assignment first!");
            }
            else
            {
                Window1 editBox = new Window1();
                editBox.Show();
            }
            
        }

        private void selectList_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void removeList_Click(object sender, RoutedEventArgs e)
        {
            //DECKER GET YOUR CRAP TOGETHER
            if (studyLists.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an assignment first!");
            }
            else
            {
                studyLists.Items.RemoveAt(studyLists.SelectedIndex);
            }
        }

        private void Management1_Closed(object sender, EventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            if (AssignmentList.getTotal() == 0)
            {
                menuWindow.fBBN.IsEnabled = false;
                menuWindow.mCBN.IsEnabled = false;
                menuWindow.Show();
            }
            else
            {
                menuWindow.Show();
                int termNums = AssignmentList.getAssignment().getTotal();

                for (int i = 0; i < termNums; i++)
                {
                    menuWindow.termList.Items.Add(AssignmentList.getAssignment().GetList(i, 0));
                }
            }
        }
    }
}
