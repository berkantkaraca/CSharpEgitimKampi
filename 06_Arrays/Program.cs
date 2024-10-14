using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[eleman sayısı]

            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" }; //boyut belirtmeden yazma 
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "sarı", "kırmızı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 576, 887, 996, 5512, 621, 325, 445, 953, 123, 78, };
            ////doğru
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //dizideki en büyük elman bulan
            //doğru

            //int[] numbers = { 2, 56, 548, 22, 33, 1456, 554, 33, 13, 1, 5112 };
            //int max;
            //max = numbers[0];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //}

            //Console.WriteLine("en büyük sayı : " + max);

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);//dizinin uzunluğu

            //short methodu sıralamaya yarar

            //int[] number = { 52, 41, 33, 21, 2, 6, 8, 7, 90, 51 };
            //Array.Sort(number);
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            //diziyi tersten sıralar 
            //int[] number = { 52, 41, 33, 21, 2, 6, 8, 7, 90, 51 };
            //Array.Reverse(number);
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            #endregion

            #region Dizi Methodları

            //dizinin elemanının indexini gösterir
            //string[] costumer = { "ali", "ayşe", "buse", "alp", "naz" };
            //int index = Array.IndexOf(costumer, "alp");
            //Console.WriteLine(index);

            //int[] numbers = { 54, 32, 68, 95, 41, 24, 2, 5, 14, 56, 34 };
            //Console.WriteLine("Dizinin en büyük elemanın : " + numbers.Max() + " Dizinin en küçük elemanı : " + numbers.Min());

            #endregion

            #region Kullanıcıdan değer alma

            //çok da doğru sayılmaz 
            //Console.Write("lütfen 5 şehir giriniz: ");
            //string[] cities = new string[5];
            //cities[0] = Console.ReadLine();
            //cities[1] = Console.ReadLine();
            //cities[2] = Console.ReadLine();
            //cities[3] = Console.ReadLine();
            //cities[4] = Console.ReadLine();

            //Console.Write("şehirler: ");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write(cities[i] + ",");

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.Write($"Lütfen {i+1}. şehri giriniz : ");
            //    //$ işareti çift tırnak içerisinde paramtresel ifade kullanmaya yarar
            //    cities[i] = Console.ReadLine();     
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            // tam sayı dizisi oluşturup dizideki elemanların toplamını yazdır 
            //doğru
            //int[] number = {5, 8, 41, 2,  9, 12, 636, 458};
            //int sum=number[0];

            //for (int i = 0; i < number.Length - 1; i++)
            //{
            //   sum = (sum + number[i + 1]);
            //}
            //Console.WriteLine("toplam : " + sum);
            //videoda sum 0 a eşit ve sum += number[i] dönüyor

            // tek ve çift sayıları yazdırma 
            //doğru
            //int[] numbers = { 10, 23, 55, 87, 95, 62, 13 };
            //Console.WriteLine("çift sayılar : ");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("tek sayılar : ");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}