using System;
using System.Data;
using System.Diagnostics.Metrics;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 2 string array-i içerisindeki ortaq elementleri tapib ekrana yazdiran metod;

            //string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8" };
            //string[] arr2 = { "2", "4", "6", "9", "11" };

            //CommonElement(arr, arr2);

            //2 eyni uzunluqlu array içerisindeki elementlerin indexlerine uygun hasilini tapib ekrana yazdiran metod

            //int[] arr = { 1, 2, 3 };
            //int[] arr2 = { 6, 7, 8 };

            //ProductIndex(arr, arr2);

            ////Array -in içerisinde verilmiş herf ile başlayan elementleri ekrana yazdıran method

            //string[] arr = { "Anar", "Eli", "Yusif", "Arif" };
            //char letter;

            //Console.WriteLine("Herf daxil edin");
            //letter = Convert.ToChar(Console.ReadLine());

            //SuitableElement(arr, letter);

            //// Area deyə Method(lar) yaradın: Çevrənin sahəsi , Düzbucaqlının sahəsi ,  Düzbucaqlı paralelpipedin tam səthinin sahəsi, Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi 


            //int r = 5;
            //int a = 2;
            //int b = 4;
            //int c = 6;

            //Console.WriteLine("Cevrenin sahesi: " + Area(r));
            //Console.WriteLine("Duzbucaqlinin sahesi: " + Area(a,b));
            //Console.WriteLine("Duzbucaqli paralipipedin sahesi: "+ Area(a,b,c));  
            //Console.WriteLine("Ucbucaqlinin daxiline cekilmis cevrenin sahesi: "+ Area(a,b,c,r));
            





        }

        //static void CommonElement(string[]arr, string[]arr2)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for(int j = 0; j < arr2.Length; j++)
        //        {
        //            if (arr[i] == arr2[j])
        //            {
        //                Console.Write(arr[i]+" ");
        //            }
        //        }
        //    }
        //}

        //static void ProductIndex(int[] arr, int[] arr2)
        //{
        //    int product = 1;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for(int j = 0; i <= arr2.Length; j++)
        //        {
        //            if (arr.Length==arr2.Length)
        //            {
        //               i = j;
        //               product= arr[i] * arr2[j];

        //            }
        //            Console.WriteLine(product);
        //        } 
        //    }

        //}

        //static void SuitableElement(string[]arr,char letter)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i].StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
        //        {
        //            Console.WriteLine(arr[i]);
        //        }
        //    }
        //}


        //static int Area(int r)
        //{
        //    int p = 3;
        //    int S = p * r * r;
        //    return S;
        //}

        //static int Area( int a, int b )
        //{
        //    int S = a * b;  
        //    return S;
        //}

        //static int Area(int a, int b, int c )
        //{
        //    int S = 2 * (a * b + a * c + b * c);
        //    return S;
        //}
        //static int Area(int a,int b, int c, int r)
        //{
        //    int p= (a+b+c)/2;
        //    int S = p*r;    
        //    return S;
        //}

    }
}
