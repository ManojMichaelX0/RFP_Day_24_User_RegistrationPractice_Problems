// UC 9 USer Test
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationDay26;

namespace UserTest
{
    //UC 9 Unit Testing
    [TestClass]
    public class RegistrationTest
    {
        //UC 1
        [TestMethod]
        [DataRow("Manoj")]//Test Will Pass
        [DataRow("manoj")]//Test Will Faile
        public void ValidateFirstName(string fname)
        {
            bool excepted = true;
            var actual = Program.FirstNameCheck(fname);
            Assert.AreEqual(excepted, actual);
        }
        //UC 2
        [TestMethod]
        [DataRow("Thiparapu")]
        [DataRow("thiparapu")]
        public void ValidateLastName(string lname)
        {
            bool excepted = true;
            var actual = Program.LastNameCheck(lname);
            Assert.AreEqual(excepted, actual);
        }
        //UC 3 and 9
        [TestMethod]
        [DataRow("manoj@gmail.com")]//test will pass
        [DataRow("abc@yahoo.com")]//test will pass
        [DataRow("abc-100@yahoo.com")]//test will pass
        [DataRow("abc.100@yahoo.com")]//test will pass
        [DataRow("abc111@abc.com")]//test will pass
        [DataRow("abc-100@abc.net")]//test will pass
        [DataRow("abc.100@abc.com.au")]//test will pass
        [DataRow("abc@1.com")]//test will pass
        [DataRow("abc@gmail.com.com")]//test will pass
        [DataRow("manoj")]//Test will Fail
        public void ValidateEmail(string mail)
        {
            bool excepted = true;
            var actual = Program.EmailCheck(mail);
            Assert.AreEqual(excepted, actual);
        }
        //UC 4
        [TestMethod]
        [DataRow("91 8106529025")]//Test Will Pass
        [DataRow("8106529025")]//Test Will Faile
        public void ValidateMobileNumber(string mobileNumber)
        {
            bool excepted = true;
            var actual = Program.MobileNumberCheck(mobileNumber);
            Assert.AreEqual(excepted, actual);
        }
        //UC 5 to 8
        [TestMethod]
        [DataRow("Password$4")]//Test Will Pass
        [DataRow("password")]//Test Will Faile
        public void ValidatePassword(string password)
        {
            bool excepted = true;
            var actual = Program.PasswordCheck(password);
            Assert.AreEqual(excepted, actual);
        }
    }
}
