using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10 ,
                                11 , 12 , 13 , 14 , 15 , 16 , 17 ,18 , 19 , 20 };

            // Select All 
            var result1 = numbers.ToArray();

            // Sort By Ascending 0 to 20 (صعودی)
            var result2 = numbers.OrderBy(n => n).ToArray();

            // Sort By Descending 20 to 0 (نزولی)
            var result3 = numbers.OrderByDescending(n => n).ToArray();

            // where (شرط)
            var result4 = numbers.Where(n => n > 10).ToArray();
            var result5 = numbers.Where(n => n > 10 && n > 15).ToArray();

            // Sort And Where
            var result6 = numbers.Where(n => n > 10 && n > 15).OrderByDescending(n => n).ToArray();

            // زمانی که نمیدانیم هست یا نیست 
            // ()First : اولین عنصر از آرایه را بر می گرداند.
            // ()First :   هنگامی که عنصری وجود نداشت با 
            //             استثنا مواجه می شود.
            var result7 = numbers.Where(n => n == 4).First();
            // Error
            //var result8 = numbers.Where(n => n == 40).First();

            // زمانی که نمیدانیم هست یا نیست 
            // ()FirstOrDefault : اولین عنصر از آرایه را بر می گرداند.
            // ()FirstOrDefault : هنگامی که عنصری وجود نداشت با استثنا مواجه نمی شود.
            var result9 = numbers.Where(n => n == 4).FirstOrDefault();
            var result10 = numbers.Where(n => n == 40).FirstOrDefault();

            // زمانی که مطمئن هستیم وجود دارد 
            // ()Single : دقیقاً 1 نتیجه وجود دارد ، در صورت عدم بازگشت نتیجه یا بیش از یک نتیجه ، یک استثنا پرتاب می شود.
            var result11 = numbers.Where(n => n == 4).Single();
            // var result12 = numbers.Where(n => n == 40).Single();

            // زمانی که مطمئن هستیم وجود دارد 
            // ()SingleOrDefault : همان است که single را
            //                     پشتیبانی میکند  null
            var result13 = numbers.Where(n => n == 4).SingleOrDefault();
            var result14 = numbers.Where(n => n == 40).SingleOrDefault();

            // Any -> True or False
            var result15 = numbers.Where(n => n == 4).Any();
            var result16 = numbers.Where(n => n == 40).Any();

            // Count
            var result17 = numbers.Count();

            // Max
            var result18 = numbers.Max();

            // Min
            var result19 = numbers.Min();

            // Sum
            var result20 = numbers.Sum();

            List<string> Names = new List<string>();
            Names.Add("Ali");
            Names.Add("Amir");
            Names.Add("Arvin");
            Names.Add("Arina");
            Names.Add("Shervin");

            // Select All
            var result21 = Names.ToList();

            // Select "a" in List
            var result22 = Names.Where(n => n.ToLower().Contains("a")).ToList();

            // Select "a" StartsWith
            var result23 = Names.Where(n => n.ToLower().StartsWith("a")).ToList();

            // Select "a" EndsWith
            var result24 = Names.Where(n => n.ToLower().EndsWith("a")).ToList();

            // Count Syntax
            int[] Distinct = { 1, 1, 2, 2, 3, 4, 4, 5, 5 };
            var result25 = Distinct.Distinct().ToList();

            // Count Conditional
            int[] Conditional = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result26 = Conditional.Count(n => n % 2 == 1);


            List<Person> people = new List<Person>();

            Person p1 = new Person()
            {
                Id = 1,
                Name = "Arvin",
                Family = "Moj",
                Age = 20
            };

            people.Add(p1);

            Person p2 = new Person()
            {
                Id = 2,
                Name = "Shervin",
                Family = "Khodami",
                Age = 21
            };

            people.Add(p2);

            Person p3 = new Person()
            {
                Id = 3,
                Name = "Arina",
                Family = "Rahimi",
                Age = 19
            };

            people.Add(p3);

            var result27 = people.ToList();

            var result28 = people.OrderBy(p => p.Age).ToList();

            var result29 = people.OrderByDescending(p => p.Age).ToArray();

            var result30 = people.Where(p => p.Age >= 20).OrderBy(p => p.Age).ToList();

            var result31 = people.Select(p => p.Name).ToList();

            var result32 = people.Select(p => new { p.Name, p.Family, p.Age }).ToList();


            // Take 
            int[] Take = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result33 = Take.OrderBy(n => n).Take(3).ToArray();
            var result34 = Take.OrderByDescending(n => n).Take(3).ToArray();

            // Skip 
            int[] Skip = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result35 = Take.OrderBy(n => n).Skip(3).ToArray();
            var result36 = Take.OrderByDescending(n => n).Take(3).ToArray();


            foreach (var item in result35)
            {
                System.Console.WriteLine(item);
                // System.Console.WriteLine($"Name: {item.Name}  Family: {item.Family} Age: {item.Age}");
            }
        }
    }
}
