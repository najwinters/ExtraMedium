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
    /// Interaction logic for AnalyticsPage.xaml
    /// </summary>
    public partial class AnalyticsPage : Window
    {
        public AnalyticsPage()
        {
            InitializeComponent();
            if (Analytics.gotFC && Analytics.gotFITB && Analytics.gotMC)
            {
                aSLBL2.Content = Analytics.getAV();
                hSLBL2.Content = Analytics.getHS();
                cSLBL2.Content = Analytics.getCS();
            }
            else
            {
                nEILBL.Visibility = Visibility.Visible;
            }

        }


        private void Window_Closed(object sender, EventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            int termNums = AssignmentList.getAssignment().getTotal();
            for (int i = 0; i < termNums; i++)
            {
                menuWindow.termList.Items.Add(AssignmentList.getAssignment().GetList(i, 0));
            }
        }
    }
}
