using StudentSystem.Data;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Management
{
    internal class CourseManager
    {
        private StudentSystemContext _db = new();

        public void AddCourses()
        {
            string? answer;
            do
            {
                Console.Write("Course name: ");
                string? name = Console.ReadLine();

                Console.Write("Description (optional): ");
                string? desc = Console.ReadLine();

                Console.Write("Start date (yyyy-MM-dd): ");
                DateTime.TryParse(Console.ReadLine(), out var start);

                Console.Write("End date (yyyy-MM-dd): ");
                DateTime.TryParse(Console.ReadLine(), out var end);

                Console.Write("Price: ");
                Decimal.TryParse(Console.ReadLine(), out var price);

                var course = new Course
                {
                    Name = name,
                    Description = desc,
                    StartDate = start,
                    EndDate = end,
                    Price = price
                };

                _db.courses.Add(course);
                _db.SaveChanges();
                Console.WriteLine("Course added!");

                Console.Write("Add another course? (y/n): ");
                answer = Console.ReadLine();
            }
            while (answer?.ToLower() == "y");
        }

        public void ListCourses()
        {
            var courses = _db.courses.ToList();
            foreach (var c in courses)
            {
                Console.WriteLine($"{c.CourseId}: {c.Name} | Start: {c.StartDate:yyyy-MM-dd} | End: {c.EndDate:yyyy-MM-dd} | Price: {c.Price:C}");
            }
        }

    }
}
