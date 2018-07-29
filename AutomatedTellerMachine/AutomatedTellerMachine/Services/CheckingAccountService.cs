using AutomatedTellerMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutomatedTellerMachine.Services
{
    public class CheckingAccountService
    {
        private ApplicationDbContext db;

        public CheckingAccountService(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        public void CreateCheckingAccount(string firstName,string lastName,string userId,decimal initialBalance)
        {
            var db = new ApplicationDbContext();
            var accountNumber = (123456 + db.CheckingAccounts.Count()).ToString().PadLeft(10, '0');
            var checkingAccount = new CheckingAccount { FirstName = firstName, LastName = lastName, AccountNumber = "0000123456", Balance = initialBalance, ApplicationUserId = userId};
            db.CheckingAccounts.Add(checkingAccount);
            db.SaveChanges();
        }
    }
}