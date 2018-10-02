using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace honapok
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] honapok = new int[] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            string[] hnevek = new string[] 
            {
                "január", 
                "február",
                "március",
                "április",
                "május",
                "június",
                "július", 
                "augusztus",
                "szeptember", 
                "október",
                "november",
                "december"
            };
            Console.WriteLine("Írj be egy hónapnak a sorszámát!");
            int sorszam = int.Parse(Console.ReadLine());
            if(sorszam <= 12 && sorszam > 0)
                Console.WriteLine("A(z) {0} hónap {1} napos.", hnevek[sorszam-1], honapok[sorszam-1]);
            else
                Console.WriteLine("Ez nem egy hónap sorszáma!");
            Console.ReadKey();
        }
    }
}
