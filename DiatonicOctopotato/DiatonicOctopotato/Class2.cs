using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiatonicOctopotato
{
    public class Assignment
    {
        private string name;
        private string[,] list;
        private int total;

        public Assignment()
        {
            name = "New Study List";
            list = new string[40, 2];
            total = 0;
        }

        public void setName(string inName)
        {
            name = inName;
        }

        public string getName()
        {
            return name;
        }

        public int getTotal()
        {
            return total;
        }

        public void incTotal() //YES I KNOW THIS IS A BAD SOLUTION. SHUT UP!
        {
            total++;
        }

        public void Save(string value, int i, int j)
        {
            list[i, j] = value;
        }

        public void Display()
        {
            foreach (var value in list)
            {
                System.Windows.MessageBox.Show(value);
            }
        }
        public string GetList(int i, int j)
        {
            return list[i,j];
        }

        internal string getList(int selectedIndex, int v)
        {
            return list[selectedIndex, v];
        }
    }
}


