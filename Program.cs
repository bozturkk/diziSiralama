using System;

namespace diziSiralama // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] ornek = new int[] {16, 23, 7, 11, 3, 14};
            List<int> dizi = new List<int> ();
            List<int> bolum1 = new List<int>();
            List<int> bolum2 = new List<int>();
            foreach ( var item in ornek)
            {
                dizi.Add(item);
            }

            dizi.Sort();
            dizi.Reverse();
            for(int i = 0; i<dizi.Count(); i++)
            {


                if(i % 2 == 0)
                {
                    bolum1.Add(dizi[i]);
                }    
                else
                {
                    bolum2.Add(dizi[i]);
                }
            }
            
            bolum2.Reverse();
            bolum1.AddRange(bolum2);
            foreach (var item in bolum1)
            {
                Console.WriteLine(item);
            }
            
         
        }
    }
}
