using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {


        public static int Rekursifsearching(int first, int last, int value)
        {
            int middle = (first + last) / 2;
            if (dizi[middle] == value)
            {
                return middle;
            }
            else if (first >= last)
            {
                return -1;
            }
            else if (value < dizi[middle])
            {
                return Rekursifsearching( first, middle-1, value);
            }
            else
            {
                return Rekursifsearching( middle+1, last, value);
            }
        }
    public static int[] dizi = new int[10];
        static void Main(string[] args)
        {
            Random uretec = new Random();
          
            for(int i=0;i<dizi.Length;i++)
            {
                dizi[i] = uretec.Next(10,20);
            }
            Array.Sort(dizi);
            int sonuc = Rekursifsearching( 0, dizi.Length - 1,15);
            Console.WriteLine(sonuc);

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
            Console.ReadLine();
        }
    }
}
