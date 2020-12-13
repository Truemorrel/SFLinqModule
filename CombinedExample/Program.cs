﻿using System;
using System.Linq;

namespace LinqModule.Unit_0.CombinedExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = {"Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян"};
           
            var selectedPeople = (from p in people
                where p.ToUpper().StartsWith("А")
                orderby p 
                select p).Count();
 
            Console.WriteLine($"В выборке {selectedPeople} чел");
        }
    }
}