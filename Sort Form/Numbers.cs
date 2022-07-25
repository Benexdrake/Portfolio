using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Form_Demo
{
    public class Numbers
    {
        public static int[] RandomNumbers(int maxNumber)
        {
            Random random = new Random();

            List<int> possible = Enumerable.Range(1, maxNumber).ToList();
            List<int> listNumbers = new List<int>();
            for (int i = 0; i < maxNumber; i++)
            {
                int index = random.Next(0, possible.Count);
                listNumbers.Add(possible[index]);
                possible.RemoveAt(index);
            }
            return listNumbers.ToArray();
        }
    }
}
