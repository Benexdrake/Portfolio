using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator_Forms
{
    

    internal class PasswordGenerator
    {
        static char[] charArray;
        static List<char> charList = new List<char>();
        static char[] low = { 'a' , 'b' ,'c' , 'd' , 'e' , 'f' , 'g' , 'h' ,'i' , 'j' , 'k' , 'l' , 'm' , 'n' ,'o' , 'p' , 'q' , 'r' , 's' , 't' ,'u' , 'v' , 'w' , 'x' , 'y' , 'z'};
        static char[] high = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q' , 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        static char[] numbers = {'0' , '1' , '2' , '3' , '4' , '5' , '6' , '7' , '8' , '9' };
        static char[] special = {'!','"','§','$','%','&','/','(',')','=','?','+','*','#',',',';', '.',':','-','_' };


        static Random rand = new Random();

        public static void combineChar(bool l, bool h, bool n, bool s)
        {
            charList.Clear();
            if(l)
            {
                ArrayToList(low);
            }
            if(h)
            {
                ArrayToList(high);
            }
            if(n)
            {
                ArrayToList(numbers);
            }
            if(s)
            {
                ArrayToList(special);
            }
            ListToArray();

        }

        private static void ArrayToList(char[] Array)
        {
            foreach (char item in Array)
            {
                charList.Add(item);
            }
        }

        private static void ListToArray()
        {
            charArray = new char[charList.Count];
            for (int i = 0; i < charList.Count; i++)
            {
                charArray[i] = charList[i];
            }
        }

        public static String Generator(int length)
        {
            int a = 0;
            int greater = 0;
            String dump = "";
            String newPW = "";
            Console.Write("Länge des PWs eingeben: ");


            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    a = rand.Next(0, charArray.Length - 1);
                    
                }
                
                newPW += charArray[a];
                
            }
            return newPW;
        }
    }
}
