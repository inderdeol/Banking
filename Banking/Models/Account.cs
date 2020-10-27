using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string AccountNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal Balance { get; set; }
    }
}
