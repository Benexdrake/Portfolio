using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmwandlerForms
{
    public class DatenGroesse
    {
        public DatenGroesse()
        {

        }

        public float Menu(int cBox1, int cBox2, float n)
        {
            switch (cBox1)
            {
                case 0:

                    return Bit(cBox2, n);
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:

                    break;
                case 10:

                    break;
                case 11:

                    break;
                case 12:

                    break;
                case 13:

                    break;
                case 14:

                    break;
                case 15:

                    break;
                case 16:

                    break;
                case 17:

                    break;
                case 18:

                    break;
                case 19:

                    break;
                case 20:

                    break;
            }


            return 0;
        }

        private float Bit(int a, float n)
        {
            switch(a)
            {
                case 1:
                    // Bit > Kilobit
                    n = n / 1000f;
                    break;
                case 2:
                    n = n / 1024f;
                    // Bit > Kibibit
                    n = n / 1e+6f;
                    break;
                case 3:
                    // Bit > Megabit
                    n = n / 1.049e+6f;
                    break;
                case 4:
                    // Bit > Mebibit
                    n = n / 1000;
                    break;
                case 5:
                    // Bit > Gigabit
                    n = n / 1000;
                    break;
                case 6:
                    // Bit > Gibibit
                    n = n / 1000;
                    break;
                case 7:
                    // Bit > Terabit
                    n = n / 1000;
                    break;
                case 8:
                    // Bit > Tebibit
                    n = n / 1000;
                    break;
                case 9:
                    // Bit > Petabit
                    n = n / 1000;
                    break;
                case 10:
                    // Bit > Pebibit
                    n = n / 1000;
                    break;
                case 11:
                    // Bit > Byte

                    break;
                case 12:
                    // Bit > Kilobyte

                    break;
                case 13:
                    // Bit > Kibibyte

                    break;
                case 14:
                    // Bit > Megabyte

                    break;
                case 15:
                    // Bit > Mebibyte

                    break;
                case 16:
                    // Bit > Gigabyte

                    break;
                case 17:
                    // Bit > Gibibyte

                    break;
                case 18:
                    // Bit > Terabyte

                    break;
                case 19:
                    // Bit > Tebibyte

                    break;
                case 20:
                    // Bit > Petabyte

                    break;
                case 21:
                    // Bit > Pebibyte

                    break;
            }

            return n;
        }
    } 
}
