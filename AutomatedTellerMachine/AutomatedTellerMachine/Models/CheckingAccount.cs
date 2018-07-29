using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutomatedTellerMachine.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }

        [Required]
        //[StringLength(10,MinimumLength =6)]
        [RegularExpression(@"\d{6,10}",ErrorMessage ="Account Number must be 6 to 10 digits")]
        [Display(Name ="Account #")]
        public string AccountNumber { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Name")]
        public string Name { get {
                return String.Format("{0} {1}",FirstName,LastName); } }

        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }


    }
}