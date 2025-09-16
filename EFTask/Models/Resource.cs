using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{

    public enum ResourceType
    {
        Video,
        Presentation,
        Document,
        Other
    }

    internal class Resource
    {
        /*
         ResourceId 
o Name (up to 50 characters, unicode) 
o Url (not unicode) 
o ResourceType (enum – can be Video, Presentation, Document or Other) 
o CourseId*/

        public int ResourceId { get; set; }
        [MaxLength(50)]
        public string? Name { get; set; }
        [Unicode(false)]
        public string? Url { get; set; }
        public ResourceType resourceType { get; set; }
        public int CourseId { get; set; }

        public Course course { get; set; }
    }
}
