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

        Rectangle rectangleFade;
        public MainWindow()
        {
            InitializeComponent();
             rectangleFade= new Rectangle();
            

        }


        private void button_Click(object sender, RoutedEventArgs e)
        {

            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
            //rectangleFade.Margin = (100,100,100,100);
            //rectangleFade.
            
                         
            menuWindow.mCBN.IsEnabled = false;
            menuWindow.fBBN.IsEnabled = false;
            menuWindow.btnFlashCards.IsEnabled = false;

            menuWindow.Show();           

        }
        private void MyAssignmentbutton_Click(object sender, RoutedEventArgs e)
        {

            Window1 win1 = new Window1();
            win1.Show();
            this.Close();

            
        }

        private void asgnBTN_Click(object sender, RoutedEventArgs e)
        {
            Management manage = new Management();
            manage.Show();
            this.Close();
        }
    }
}
