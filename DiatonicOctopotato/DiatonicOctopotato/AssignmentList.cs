using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DiatonicOctopotato
{
    public static class AssignmentList
    {
        private const int MAX_ASSIGNMENTS = 10;

        public static Assignment[] list; // Yep, not confusing at all. Promise. (Castaldo if you're reading this I write better code than this, sometimes. ~Decker)
        private static int curAssignment;
        private static int total;

        static AssignmentList()
        {
            curAssignment = 0; //Totally won't cause any errors. Promise.
            total = 0;
            list = new Assignment[MAX_ASSIGNMENTS];
        }

        static public Assignment getAssignment()
        {
            return list[curAssignment];
        }

        static public Assignment getAssignment(int index)
        {
            return list[index];
        }

        static public int getCurIndex()
        {
            return curAssignment;
        }

        static public int getTotal()
        {
            return total;
        }

        static public void setAssignment(int selector)
        {
            curAssignment = selector;
        }

        static public void removeAssignment(int index)
        {
            if(index < total)
            {
                for(int i = index; i < total-1; i++)
                {
                    list[i] = list[i + 1];
                }
                total--;
            }
        }

        static public void createList(string name) //Should be createAssignment().
        {
            if (total < 10)
            {
                list[total] = new Assignment();
                list[total].setName(name);
                total++;
            }
            else
            {
                MessageBox.Show("You've reached the maximum number of assignments!");
            }
        }
    }

}
