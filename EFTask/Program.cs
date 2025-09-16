using StudentSystem.Data;
using StudentSystem.Management;
using StudentSystem.Models;

namespace StudentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StudentSystemContext db = new();
            db.Database.EnsureCreated();

            var studentManager = new StudentManager();
            var courseManager = new CourseManager();

            bool exit = false;
            do
            {
                Console.WriteLine("\nStudent System Menu:");
                Console.WriteLine("1. Add Students");
                Console.WriteLine("2. Add Courses");
                Console.WriteLine("3. List Students");
                Console.WriteLine("4. List Courses");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        studentManager.AddStudents();
                        break;
                    case "2":
                        courseManager.AddCourses();
                        break;
                    case "3":
                        studentManager.ListStudents();
                        break;
                    case "4":
                        courseManager.ListCourses();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

            }
            while (!exit);

        } } 
}
