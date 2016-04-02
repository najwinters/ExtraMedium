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
using System.IO;
using Microsoft.Win32;
using System.Media;

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
            MenuWindow menuWindow = new MenuWindow();
            if (studyLists.SelectedIndex != -1) {
                AssignmentList.setAssignment(studyLists.SelectedIndex);
            }
            else
            {
                MessageBox.Show("");
            }
            
        }

        private void ImportListButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            if(openDialog.ShowDialog() == true)
            {
                using (StreamReader sr = new StreamReader(openDialog.FileName))
                {
                    AssignmentList.createList(sr.ReadLine());
                    Assignment curAssignment = AssignmentList.getAssignment(AssignmentList.getTotal()-1); //Because Reasons. Don't question it.
                    while(!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] term = line.Split('\t');
                        if(term.Length == 2)
                        {
                            curAssignment.Save(term[0], curAssignment.getTotal(), 0);
                            curAssignment.Save(term[1], curAssignment.getTotal(), 1);
                            curAssignment.incTotal();
                        }
                    }
                    sr.Close();
                }
            }
            loadAssignmentList();
        }

        private void ExportListButton_Click(object sender, RoutedEventArgs e)
        {
            if(studyLists.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an assignment first!");
            }
            else
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                if(saveDialog.ShowDialog() == true)
                {
                    using (StreamWriter sw = new StreamWriter(saveDialog.FileName))
                    {
                        Assignment curAssignment = AssignmentList.getAssignment(studyLists.SelectedIndex);
                        sw.WriteLine(curAssignment.getName());
                        for(int i = 0; i < curAssignment.getTotal(); i++)
                        {
                            sw.WriteLine(curAssignment.GetList(i, 0) + "\t" + curAssignment.getList(i, 1));
                        }
                        sw.Close();
                    }
                }
            }
        }
        private static readonly Key[] _kC = new[] { Key.Up, Key.Up, Key.Down, Key.Down, Key.Left, Key.Right, Key.Left, Key.Right, Key.B, Key.A };
        int _kCI = 0;


        protected override void OnPreviewKeyDown(KeyEventArgs e)
        {
            base.OnPreviewKeyDown(e);
            if (e.Key == _kC[_kCI])
            {
                _kCI++;
                if (_kCI == _kC.Length)
                {
                    _kCI = 0;
                    kEE();
                }
            }
            else
            {
                _kCI = 0;
            }
        }

        void kEE()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\wintenat000\Documents\Visual Studio 2015\Projects\ExtraMedium\DiatonicOctopotato\DiatonicOctopotato\images\mySound.wav");
            simpleSound.Play();
        }
        private void removeList_Click(object sender, RoutedEventArgs e)
        {
            //DECKER GET YOUR CRAP TOGETHER
            // NO! ~Decker
            if (studyLists.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an assignment first!");
            }
            else
            {
                AssignmentList.removeAssignment(studyLists.SelectedIndex);
                loadAssignmentList();
            }
        }

        private void Management1_Closed(object sender, EventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            if (AssignmentList.getTotal() == 0 || AssignmentList.getAssignment().getTotal() == 0)
            {
                menuWindow.fBBN.IsEnabled = false;
                menuWindow.mCBN.IsEnabled = false;
                menuWindow.btnFlashCards.IsEnabled = false;
                menuWindow.Show();
            }
            else if(AssignmentList.getAssignment().getTotal() < 4)
            {
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
