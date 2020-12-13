﻿using System;
using System.Linq;
 
namespace LinqModule.Unit_0.ExtensionMethodsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = {"Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян"};
 
            var selectedPeople = people.Where(p => p.StartsWith("А")).OrderBy(p => p);
          
            foreach (string s in selectedPeople)
                Console.WriteLine(s);
        }
    }
}