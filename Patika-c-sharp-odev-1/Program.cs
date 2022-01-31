using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_c_sharp_odev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.*/
            Console.WriteLine("Lütfen pozitif bir sayı giriniz");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Lütfen kullanıcıya {0} adet pozitif sayı giriniz.", n);
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine("Girmiş olduğunuz {0} sayısı çifttir.", array[i]);
                }
                else
                {
                    Console.WriteLine("Lütfen çift sayılar giriniz.");
                    break;
                }
            }
            /*2-Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (x, m). Sonrasında kullanıcıdan x adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.*/
            Console.WriteLine("Lütfen pozitif bir sayı giriniz");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("x={0}",x);
            Console.WriteLine("Lütfen pozitif bir sayı giriniz");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("m={0}", x);
            int[] array2 = new int[x];
            Console.WriteLine("Lütfen kullanıcıya {0} adet pozitif sayı giriniz.", x);
            for (int j = 0; j < x; j++)
            {
                array2[j] = int.Parse(Console.ReadLine());
                if (array2[j] % m == 0 || array2[j] == m)
                {
                    Console.WriteLine("Girmiş olduğunuz {0} sayısı m'e eşit veya tam bölünür", array2[j]);
                }
                else
                {
                    Console.WriteLine("Lütfen  m'e eşit yada tam bölünen sayılar giriniz");
                    break;
                }
            }
            /*3-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (c). Sonrasında kullanıcıdan c adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.*/
             Console.WriteLine("Lütfen pozitif bir sayı giriniz");
             int c = int.Parse(Console.ReadLine());
             Console.WriteLine("Girdiniz sayi:{0}",c);
             string[] array3 = new string[c];
             Console.WriteLine("Lutfen {0} tane karakter giriniz.", c);
             for (int k = 0; k < c; k++)
             {

                 string p = Console.ReadLine();
                 array3[k] = p;


             }

            Array.Reverse(array3);
             foreach(string item in array3)
             {
                 Console.WriteLine(item);
             }
            /*4-Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.*/
            string cumle;
            Console.WriteLine("Lütfen bir cümle giriniz.");
            cumle = Console.ReadLine();
            int kelime = 1;
            for(int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i] == ' ')
                {
                    kelime++;
                }
            }
            cumle=cumle.Replace(" ","");
            int a = cumle.Length;
            Console.WriteLine("Cümledeki harf sayısı:"+a);
            Console.WriteLine("Cümledeki kelime sayısı:" + kelime);


        }
    }
}
