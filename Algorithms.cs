using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_lab1
{
    class Algorithms
    {
        public static int[] Insertion_Sort(int[] mass, bool ascending = true)
        {
            int key = 0;
            int i;
            
            for (int j = 1; j < mass.Length; j++)
            {
                key = mass[j];
                i = j - 1;

                if (ascending == true)
                {
                    while (i >= 0 && mass[i] > key)
                    {
                        mass[i + 1] = mass[i];
                        i = i - 1;
                    }
                    mass[i + 1] = key;
                }
                else
                {
                    while (i >= 0 && mass[i] < key)
                    {
                        mass[i + 1] = mass[i];
                        i = i - 1;
                    }
                    mass[i + 1] = key;
                }
            }

            return mass;            
        }

        public static string[] SimpleSearch(int[] mass, int required_obj)
        {
            string[] answer = new string[1];

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] == required_obj)
                    return answer =  new[] { i.ToString(), mass[i].ToString()};
            }

            return null;
        }
    }
}
