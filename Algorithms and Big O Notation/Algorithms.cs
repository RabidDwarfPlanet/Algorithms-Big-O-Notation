using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Big_O_Notation
{
    public static class Algorithms
    {
        //Time Complexity: O(1)
        public static bool Parity(int number)
        {
            int remainder = number % 2;
            if(remainder == 1) { return false; }
            else { return true; }
        }

        //Time Complexity: O(n)
        public static bool LessThan100(List<int> intList)
        {
            foreach(int number in intList)
            {
                if(number > 99) { return false; }
            }
            return true;
        }

        //Time Complexity: O(n)
        public static bool Repeats(List<string> names)
        {
            HashSet<string> compare = new HashSet<string>();
            foreach(string name in names)
            {
                if (compare.Contains(name)) { return false; }
                else { compare.Add(name); }
            }
            return true;
        }

        //Time Complexity: O(n²)
        public static List<int> Sort(List<int> list)
        {
            var sorting = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                bool placed = false;
                if (i == 0) { sorting.Add(list[i]); }
                else
                {
                    foreach (int item in sorting)
                    {
                        if (Comparer.Default.Compare(list[i], item) < 0)
                        {
                            sorting.Insert(sorting.IndexOf(item), list[i]);
                            placed = true;
                            break;
                        }

                    }
                    if (!placed)
                    {
                        sorting.Add(list[i]);
                    }
                }
            }
            list = sorting;
            return list;
        }
    }
}
