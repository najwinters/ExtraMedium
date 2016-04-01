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
        int termNum = 0;
        public Window1()
        {
            InitializeComponent();
            
        }

        public void button_Click(object sender, RoutedEventArgs e)
        {
            string term = termTB.Text;
            string definition = defTB.Text;
            Assignment.Save(term, termNum, 0);
            Assignment.Save(definition, termNum, 1);
            termTB.Text = "";
            defTB.Text = "";
            termNum++;
            tNLabel.Content = "Number of Terms: " + termNum;
            if (termNum == 40) {
                button.IsEnabled = false;
            }

        }

        private void termTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            
           
        }
    }
}
