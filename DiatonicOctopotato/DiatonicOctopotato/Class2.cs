using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiatonicOctopotato
{
    class Assignment
    {
        public Assignment()
        {

        }
        static string[,] list = new string[40, 2];

        public static void Save(string value, int i, int j)
        {
            
            list[i, j] = value;
        }

        public static void Display()
        {
            foreach (var value in list)
            {
                System.Windows.MessageBox.Show(value);
            }
        }
        public static string GetList(int i, int j)
        {
            return list[i,j];
        }

        internal static string getList(int selectedIndex, int v)
        {
            return list[selectedIndex, v];
        }
    }
}


