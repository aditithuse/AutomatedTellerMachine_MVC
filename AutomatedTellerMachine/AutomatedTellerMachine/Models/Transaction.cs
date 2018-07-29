using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutomatedTellerMachine.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        //forign key
        [Required]
        public int CheckingAccountId { get; set; }
        //navigation property -foreign key
        public virtual CheckingAccount CheckingAccount { get; set; }
    }
}