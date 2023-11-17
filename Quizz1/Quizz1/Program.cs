using Quizz1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Quizz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ProgramProvision> list = new List<ProgramProvision>();
            list.Add(new Free("Tornike", "Phridoni", new DateTime(2003, 11, 03)));
            list.Add(new Free("nika", "anzori", new DateTime(2007, 01, 11)));
            list.Add(new Free("giorgi", "mamuka", new DateTime(2013, 12, 31)));
            list.Add(new Free("luka", "sandrika", new DateTime(2018, 05, 15)));
            list.Add(new Free("bacho", "vaja", new DateTime(1985, 07, 03)));

            list.Add(new Try("tornike", "akhobadze", new DateTime(2003, 11, 03), new DateTime(2005, 11, 03), new DateTime(2023, 11, 03)));
            list.Add(new Try("john", "doe", new DateTime(1990, 5, 15), new DateTime(1995, 5, 15), new DateTime(2023, 5, 15)));
            list.Add(new Try("mary", "smith", new DateTime(1985, 8, 20), new DateTime(1989, 8, 20), new DateTime(2024, 8, 20)));
            list.Add(new Try("alex", "brown", new DateTime(2000, 2, 10), new DateTime(2002, 2, 10), new DateTime(2024, 2, 10)));
            list.Add(new Try("sara", "jones", new DateTime(1998, 12, 5), new DateTime(2000, 12, 5), new DateTime(2023, 12, 5)));

            list.Add(new Comercial("tornike", "akhobadze", new DateTime(2003, 11, 03), new DateTime(2005, 11, 03), new DateTime(2023, 11, 03), 1500));
            list.Add(new Comercial("john", "doe", new DateTime(1995, 7, 20), new DateTime(1997, 7, 20), new DateTime(2024, 7, 20), 2000));
            list.Add(new Comercial("mary", "smith", new DateTime(1989, 12, 15), new DateTime(1992, 12, 15), new DateTime(2022, 12, 15), 1800));
            list.Add(new Comercial("alex", "brown", new DateTime(2002, 3, 5), new DateTime(2004, 3, 5), new DateTime(2025, 3, 5), 2200));
            list.Add(new Comercial("sara", "jones", new DateTime(2000, 8, 10), new DateTime(2002, 8, 10), new DateTime(2023, 8, 10), 2500));


            Console.WriteLine("(\"==============================================Before Sort");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }

            Console.WriteLine("==============================================After Sort");
            list.Sort((x, y) => x.UseDate.CompareTo(y.UseDate));

            List<ProgramProvision> NewList = new List<ProgramProvision>();


            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }

            Console.WriteLine("==============================================Only Ture");
            foreach (var item in list)
            {
                if (item.UseDate > 0)
                {
                    NewList.Add(item);
                }
            }
            for (int i = 0; i < NewList.Count; i++)
            {
                Console.WriteLine(NewList[i].ToString());
            }

            Console.Write("Please Enter Year of trial: ");
            int UserInputYear = Int32.Parse(Console.ReadLine());
            Console.Write("Please Enter Month of trial: ");
            int UserInputMonth = Int32.Parse(Console.ReadLine());
            Console.Write("Please Enter Day of trial: ");
            int UserInputDay = Int32.Parse(Console.ReadLine());

            DateTime UserInputDate = new DateTime(UserInputYear, UserInputMonth, UserInputDay);

            Console.WriteLine("=======================================================================================SEARCH RESULT =>");

            foreach (var item in NewList)
            {
                if(item.CheckDate == UserInputDate)
                {
                    Console.WriteLine(item.ToString());
                }
            }

        }
    }
}
