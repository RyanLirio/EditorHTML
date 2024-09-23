using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditorHTML2
{
    public class Linha
    {
        public static void Linhas()
        {
            Console.Write("+");
            for (int i = 0; i <= 26; i++)
            {
                Console.Write("-");
            }
            
            Console.WriteLine("+");
        }
    }
}