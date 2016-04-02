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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            loadTermList();   
        }

        private void loadTermList()
        {
            Assignment curAssignment = AssignmentList.getAssignment();
            int total = curAssignment.getTotal();
            if (total > 0)
            {
                termList.Items.Clear();
                for (int i = 0; i < total; i++)
                {
                    termList.Items.Add(curAssignment.GetList(i, 0)); // 0 == term. Should set a const for it but whatev.
                }
            }
        }

        public void button_Click(object sender, RoutedEventArgs e)
        {
            if (termList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item first!");
            }
            else
            {
                string term = termTB.Text;
                string definition = defTB.Text;
                Assignment curAssignment = AssignmentList.getAssignment();
                curAssignment.Save(term, termList.SelectedIndex, 0);
                curAssignment.Save(definition, termList.SelectedIndex, 1);
                tNLabel.Content = "Number of Terms: " + curAssignment.getTotal();
                if (curAssignment.getTotal() == 40)
                {
                    button.IsEnabled = false;
                    tLLabel.Content = "Term Limit Reached!";
                    tLLabel.Visibility = Visibility.Visible;
                }
                loadTermList();
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            //Nathan you're a terrible person.
        }

        private void addTerm_Click(object sender, RoutedEventArgs e)
        {
            Assignment curAssignment = AssignmentList.getAssignment();
            curAssignment.Save("Term", curAssignment.getTotal(), 0);
            curAssignment.Save("Definition", curAssignment.getTotal(), 1);
            curAssignment.incTotal();
            loadTermList();
        }

        private void termList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (termList.SelectedIndex >= 0)
            {
                Assignment curAssignment = AssignmentList.getAssignment();
                termTB.Text = curAssignment.GetList(termList.SelectedIndex, 0);
                defTB.Text = curAssignment.GetList(termList.SelectedIndex, 1);
            }
        }
        private void removeTerm_Click(object sender, RoutedEventArgs e)
        {
            if (termList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a term first!");
            }
            else
            {
                termList.Items.RemoveAt(termList.SelectedIndex);
            }
        }

    }
}
