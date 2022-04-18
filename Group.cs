using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Models
{
    class Group
    {
        public string No;
        public bool IsOnline=false;
        public int Limit;
        List<Student> students;
        public Categories categories;
        public static int BP = 100;
        public static int BD = 100;
        public static int BS = 100;
        public Group(Categories category, bool isOnline)
        {
            IsOnline = isOnline;
            switch (category)
            {
                case Categories.Programming:
                    No = $"BP{BP}";
                    BP++;
                    break;
                case Categories.Design:
                    No = $"BD{BD}";
                    BD++;
                    break;
                case Categories.SystemAdministration:
                    No = $"BS{BS}";
                    BS++;
                    break;
                default:
                    Console.WriteLine("Bele bir qrup yoxdur");
                    break;
            }
            categories = category;
            if (!isOnline)
            {
                Limit = 15;
                return;
            }
            else
            {
                Limit = 10;
            }
            
        }
    }
}
