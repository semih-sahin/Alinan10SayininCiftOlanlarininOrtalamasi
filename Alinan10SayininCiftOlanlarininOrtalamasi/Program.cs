using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alinan10SayininCiftOlanlarininOrtalamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi=new int[10];
            int i = 0, adet = 0, j = 0, top = 0;
            Console.WriteLine("Sizden 10 adet sayi alacagiz ve girdiginiz sayilarin sadece cift olanlarinin ortalamasini bulacagiz.");
            Console.WriteLine("Haydi baslayalim.");
            while (i < 10)
            {
                Console.Write((i + 1) + ". sayiyi giriniz: ");
                dizi[i] = int.Parse(Console.ReadLine());
                if (dizi[i]%2==0)
                {
                    adet++;
                    top += dizi[i];
                }
                i++;
            }
            int[] dizi2 = new int[adet];
            Console.Clear();
            Console.WriteLine("Girdiginiz sayilar arasindan cift olanlar:");
            i = 0;
            A20:;
            if (i == 10)
            {
                goto A30;
            }
            if (dizi[i] % 2 == 0)
            {
                dizi2[j] = dizi[i];
                Console.WriteLine(dizi2[j]);
                j++;
            }
            else
            {
                i++;
                goto A20;
            }
            i++;
            goto A20;
            A30:;
            Console.WriteLine("********");
            Console.WriteLine("ve bu sayilarin ortalamasi = " + (top / adet));
            Console.ReadKey();
        }
    }
}
