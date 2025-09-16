using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    enum ContentType
    {
        Application,
        Pdf,
        Zip
    }
    internal class Homework
    {
        /*
       HomeworkId 
o Content (string, linking to a file, not unicode) 
o ContentType (enum – can be Application, Pdf or Zip) 
o SubmissionTime 
o StudentId 
o CourseId */
        public int HomeworkId { get; set; }
        [Unicode(false)]
        public string? Content { get; set; }
        public ContentType ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public Student? student { get; set; }
        public Course? course { get; set; }

    }
}
