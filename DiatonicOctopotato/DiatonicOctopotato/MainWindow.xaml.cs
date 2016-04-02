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
<<<<<<< HEAD
            this.Hide();
            menuWindow.mCBN.IsEnabled = false;
            menuWindow.fBBN.IsEnabled = false;
=======
            this.Close();
>>>>>>> 27d53424fb8e171945c90ec6fb59b8bebf56009a
            menuWindow.Show();           
        }
        private void MyAssignmentbutton_Click(object sender, RoutedEventArgs e)
        {

            MenuWindow menuWindow = new MenuWindow();
            this.Close();
            menuWindow.Show();
        }


    }
}
