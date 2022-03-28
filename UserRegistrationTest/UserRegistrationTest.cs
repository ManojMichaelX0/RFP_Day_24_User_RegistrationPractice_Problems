using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationDay26;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        //validation for first Name
        [TestMethod]
        [DataRow("Manoj","Manoj")]//Test will Pass
        [DataRow("manoj","Manoj")]//Test will Pass

        public void ValidateFirstname(string a, string expected)
        {

            var actual = RegexSample.ValidatingFirstName(a);
            Assert.AreEqual(expected, actual);
        }
        //Validating for Last Name
        [TestMethod]
        [DataRow("Thiparapu","Thiparapu")]//Test will Pass
        [DataRow("thiparapu","Thiparapu")]//Test will Pass

        public void ValidateUserLastname(string a, string expected)
        {
            var actual = RegexSample.ValidatingLastName(a);
            Assert.AreEqual(expected, actual);
        }
        //Validation for Email
        [TestMethod]
        [DataRow("abc@gmail.com", "abc@gmail.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc111@yahoo.com", "abc111@yahoo.com")]
        [DataRow("abc111@abc.com", "abc111@abc.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        

        public void ValidateUserEmail(string a, string expected)
        {
            var actual = RegexSample.ValidatingEmailId(a);
            Assert.AreEqual(expected, actual);
        }

        //Validation for Phone Number
        [TestMethod]
   
        [DataRow("91 8106529025","91 8106529025")]//Test Will Pass
        [DataRow("8106529025","(91 8106529025")]//Test will Fail
        
        public void ValidateUserPhoneNumber(string a, string expected)
        {
            var actual = RegexSample.ValidatingPhoneNum(a);
            Assert.AreEqual(expected, actual);
        }

        ////Validation for Password
        [TestMethod]
        [DataRow("Manoj@123", "Manoj@123")]//Will Pass
        [DataRow("Man#it123", "Man#lini123")]//Will Pass
        [DataRow("Man@oj1A ", "Manoj1A")]//Will Fail
       

        public void ValidateUserPassword(string a, string expected)
        {
            var actual = RegexSample.ValidatingPassWord(a);
            Assert.AreEqual(expected, actual);
        }



    }
}