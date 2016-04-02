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
    /// Interaction logic for NewAssignment.xaml
    /// </summary>
    public partial class NewAssignment : Window
    {
        public NewAssignment()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void buttonDone_Click(object sender, RoutedEventArgs e)
        {
            AssignmentList.createList(NameBox.Text);
            this.Close();
        }
    }
}
