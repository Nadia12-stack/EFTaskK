using StudentSystem.Data;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentSystem.Management
{
    internal class StudentManager
    {
        private StudentSystemContext _db = new();

        public void AddStudents()
        {
            string? answer;
            do
            {
                Console.Write("Student name: ");
                string? name = Console.ReadLine();

                Console.Write("Phone number (10 Number): ");
                string? phone = Console.ReadLine();

                Console.Write("Registered on (year-Mounth-day): ");
                DateTime? registeredOn = DateTime.TryParse(Console.ReadLine(), out var regOn) ? regOn : null;

                Console.Write("Birthday (year-Mounth-day): ");
                DateOnly birthday = DateOnly.MinValue;
                var birthdayInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(birthdayInput) && DateOnly.TryParse(birthdayInput, out var bday))
                    birthday = bday;

                
                var student = new Student
                {
                    Name = name,
                    PhoneNumber = phone,
                    RegisteredOn = registeredOn,
                    Birthday = birthday
                };

                _db.students.Add(student); 
                _db.SaveChanges();
                Console.WriteLine("Student added!");

                Console.Write("Add another student? (y/n): ");
                answer = Console.ReadLine();
            }
            while (answer?.ToLower() == "y");
        }

        public void ListStudents()
        {
            var students = _db.students.ToList();
            foreach (var s in students)
            {
                Console.WriteLine($"{s.StudentId}: {s.Name} | Phone: {s.PhoneNumber} | Registered: {s.RegisteredOn} | Birthday: {s.Birthday}");
            }
        }
    }
}