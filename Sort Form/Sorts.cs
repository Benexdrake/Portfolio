using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Form_Demo
{
    public class Sorts
    {
        public async Task BubbleSort(CancellationToken token, Form1 forms, Graphics g, int maxNumber, int speed)
        {
            int[] randomArray = Numbers.RandomNumbers(maxNumber);

            for (int i = 0; i < randomArray.Length; i++)
            {
                for (int j = i + 1; j < randomArray.Length; j++)
                {
                    int a1 = randomArray[i];
                    int a2 = randomArray[j];

                    if (a1 > a2)
                    {
                        if (token.IsCancellationRequested)
                        {
                            return;
                        }

                        int temp = randomArray[i];

                        randomArray[i] = randomArray[j];

                        randomArray[j] = temp;
                    }
                }
                if (speed > 0)
                    await Task.Delay(speed);
                forms.Draw();
                g.Clear(Color.Black);
            }
        }
    }
}
