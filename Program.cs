using System;
using System.Collections;
using System.Collections.Generic;

namespace ARRAYLIIST
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collection namspace
            ArrayList liste = new ArrayList();
            // liste.Add("Halil");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('A');

            // Console.WriteLine(liste[1]);

            // foreach (var item in liste)
            //     Console.WriteLine(item);
                
            
            //AddRange 
            Console.WriteLine("***********Add Range***********");
            //string[] renkler = {"Kırmızı","Sarı","Yeşil","Siyah"};
            List<int> numbers = new List<int>(){1,2,3,45,4,6,7,8,9,21};
            liste.AddRange(numbers);

            foreach (var item in liste)
                Console.WriteLine(item);

            //Sort
            Console.WriteLine("***** Sort *****");
            liste.Sort();

            foreach (var item in liste)
                Console.WriteLine(item);

            //BinarySearch

            Console.WriteLine("*****Binary Search******");
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            Console.WriteLine("***** Reverse *****");
            liste.Reverse();
            foreach (var item in liste)
                Console.WriteLine(item);

            //Clear
            Console.WriteLine("***** Clear *****");
            liste.Clear();
            foreach (var item in liste)
                Console.WriteLine(item);
        }
    }
}
