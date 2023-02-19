using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NarqueKeyGen
{
    class Program
    {
        static void Main(string[] args) {
            string pHarfler;
            string pSayilar;
            string pIsaretler;
            int harfSayi;
            int sayiSayi;
            int isaretSayi;
            Console.Write("Enter how many digits your password will be:");
            harfSayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Password has been created:");
            for (int i = 0; i < harfSayi; i++)
            {
                Random rnd = new Random();

                string[] harfler = { "a","A","b","B","c","C","d","D","e","E","f","F","g","G","h","H","I","i","j","J","k","K","l","L","m","M","n","N","o","O","p","P","q","Q","r","R","s","S","t","T","u","U","v","V","w","W","x","X","y","Y","z", "!", "–", "_", "+", "#", "$", "%", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                int hIndex = rnd.Next(harfler.Length);
                pHarfler = harfler[hIndex];
                Console.Write(pHarfler);
            }

        }
    }
}