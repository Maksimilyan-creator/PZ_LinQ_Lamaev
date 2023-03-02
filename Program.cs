using PZ_LinQ_Lamaev;
using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
     class Program
     {
        static List<Group_log> group_s;
        static List<string> Items1 = new List<string> { "Математика", "Русский язык", "География", "Химия" };
        static List<string> Students1 = new List<string> { "Молчанов", "Петров", "Андреев", "Лебедев" };
        static List<Group_log> group_а;
        static List<string> Items2 = new List<string> { "Математика", "Русский язык", "География" };
        static List<string> Students2 = new List<string> { "Молчанов", "Петров", "Андреев", "Лебедев", "Григорий" };



        static void Main(string[] args)
        {
            group_s =  new List<Group_log>()
            {
                new Group_log("Олег",Items1,Students1)
            };
            group_а = new List<Group_log>()
            {
                new Group_log("Антон", Items2,Students2)
            };
            //var kok = group_s.Select(u => u.Items.Where(u=>u == "Математика")).ToList();
            //kok.ForEach(u =>Console.WriteLine(u)); 
            var a = group_а.Where(u => u.Items.Count >= 3 && u.Students.Count >= 5).ToList();
            a.ForEach(u => Console.WriteLine(u.Classroom_teacher));
        }
           
    }

    
}
