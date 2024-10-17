using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForEachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach döngüsü

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul" };
            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 52, 63, 85, 369, 45321, 47 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 52, 63, 85, 369, 45321, 47 };
            //foreach (int number in numbers)
            //{
            //    if(number%2==0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 52, 63, 85, 369, 45321, 47 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek sınav sistemi uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.Write("Sınıftaki öğrenci sayısını girin: ");
            int studentCount = int.Parse(Console.ReadLine());
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin adını girin: ");
                studentNames[i] = Console.ReadLine();
                double totalExamResult = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu girin: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
            }

            #endregion

            Console.Read();
        }
    }
}
