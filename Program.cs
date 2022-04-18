using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Icra edeceyiniz prossesi secin:");
            Console.WriteLine("1.Yeni qrup yarat");
            Console.WriteLine("2.Qruplarin siyahisini goster");
            Console.WriteLine("3.Qrup uzerinde duzelis et");
            Console.WriteLine("4.Qrupdaki telebelerin siyahisini goster");
            Console.WriteLine("5Butun telebelerin siyahisini goster");
            Console.WriteLine("6.Telebe yarat");
            Console.ReadLine();
            string process = Console.ReadLine();
            List<Group> groups = new List<Group>();
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Yeni qrup yaradilmasi ucun lazimi melumatlari daxil edin");
                    Console.Write("No\nLimit\n");
                    //if ()
                    //{

                    //}
                    break;
                case "2":
                    Console.WriteLine();
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;  
                case "6":
                    break;
                default:
                    break;
            }
        }
    }
}
