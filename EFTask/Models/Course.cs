using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    internal class Course
    {
        /*
          CourseId 
o Name (up to 80 characters, unicode) 
o Description (unicode, not required) 
o StartDate 
o EndDate 
o Price 
         
         */

        public int CourseId { get; set; }

        [MaxLength(80) ]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Decimal Price { get; set; }

        public List<StudentCourse>? studentCourse { get; set; }
        public List<Resource>?resources { get; set; }
        public List<Homework>? homeworkhs { get; set; }

    }
}
