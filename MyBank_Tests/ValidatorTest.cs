using NUnit.Framework;
using ATMapp_new;
using ATMapp_new.Controller;
using BankAppWeek3.ErrorChecker;

namespace MyBank_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidateName()
        {
            var name = "Kachi";
            var nameValidator = ErrorValidators.Checkename("Kachi","");            
            Assert.That(name, Is.EqualTo(nameValidator));
        }

        [Test]
        public void ValidateEmail()
        {
            var email = "ocobute@gmail.com";
            var emailValidator = ErrorValidators.Checkemail("ocobute@gmail.com", "");
            Assert.That(email, Is.EqualTo(emailValidator));
        }

        [Test]
        public void ValidatePassword()
        {
            var password = "esut@1234";
            var passwordValidator = ErrorValidators.Checkpassword("esut@1234", "");
            Assert.That(password, Is.EqualTo(passwordValidator));
        }

        [Test]
        public void Amount_AccNum()
        {
            var accNum = "1";
            var accountNum_c = ErrorValidators.Amount_AccNumCheck("1", "");
            Assert.That(accNum, Is.EqualTo(accountNum_c));
        }
    }
}