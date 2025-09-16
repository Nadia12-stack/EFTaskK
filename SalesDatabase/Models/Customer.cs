using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Models
{
    internal class Customer
    {
        

        public int CustomerId { get; set; }
        [MaxLength(100)]
        public string? Name { get; set; }
        [MaxLength(80),Unicode(false)]
        public string? Email { get; set; }
        public string? CreaditCardNumber { get; set; }
        public List<Sale> Sales { get; set; }

    }
}
