using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    internal class Student
    {
        /*StudentId 
o Name (up to 100 characters, unicode) 
o PhoneNumber (exactly 10 characters, not unicode, not required) 
o RegisteredOn (DateTime) 
o Birthday (not required) 
         
         */
        
        public int StudentId { get; set; }
        [MaxLength (100)]
        public string? Name { get; set; }
      //  [MaxLength(10),MinLength(10)]
        [StringLength(10, MinimumLength= 10),Unicode(false)]
        public string PhoneNumber { get; set; }
        public DateTime? RegisteredOn { get; set; }
        public DateOnly Birthday { get; set; }


        public List<StudentCourse>? studentCourse { get; set; }
        public List<Homework>? homeworkhs { get; set; }

    }
}
