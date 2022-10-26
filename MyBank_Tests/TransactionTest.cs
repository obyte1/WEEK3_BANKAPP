using BankAppWeek3.ErrorChecker;
using BankAppWeek3.Models;
using BankAppWeek3.TransactionCodes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank_Tests
{
    public class TransactionTest
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidateName()
        {
            var name = "";
            var type = "";
            var email = "";
            var  acc = TransactionsActions.DisplayMoney("","","");          
            
            //Assert.That(name, Is.EqualTo(acc());

            //var nameValidator = ErrorValidators.Checkename("Kachi", "");
            //Assert.That(name, Is.EqualTo(nameValidator));
        }

        [Test]
        public void Withdraw()
        {
            
        }
    }
}
