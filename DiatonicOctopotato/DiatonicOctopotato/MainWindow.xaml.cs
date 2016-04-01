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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DiatonicOctopotato
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public String[,] list = new string[2, 10];
        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window1 nTWin = new Window1();
            nTWin.Show();
        }

        private void mCBN_Click(object sender, RoutedEventArgs e)
        {
            MultipleChoice mCWin = new MultipleChoice();
            mCWin.Show();

           
        }

        private void inputListBN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
//Ignore this line. Added for testing purposes.
