using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coba_Prima_Github
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan angka untuk cek prima : ");
            int angka = Convert.ToInt32(Console.ReadLine());
            int jumlah = 0;
            for (int i = 1; i <= angka; i++)
            {
                int sisa = angka % i;
                if (sisa == 0)
                {
                    jumlah = jumlah + 1;
                }
                
            }
            if (jumlah > 2)
            {
                Console.WriteLine("Bukan anka prima");
            }
            else
            {
                Console.WriteLine("Angka prima");
            }
        }
    }
}
