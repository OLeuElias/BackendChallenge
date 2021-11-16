using Microsoft.VisualStudio.TestTools.UnitTesting;
using Itau.Validators;
namespace ItauTest
{
    [TestClass]
    public class ItauTest
    {
        private string _password = "AbTp9!fok";
        private IPassword _validator;

        public ItauTest(){
            _validator = new PasswordValidator(_password);
        }

        [TestMethod]
        public void TestLowerCase()
        {
            _validator.hasLowercase();
            Assert.IsTrue(_validator.validate());
        }
        [TestMethod]
        public void TestUpperCase()
        {
            _validator.hasUppercase();
            Assert.IsTrue(_validator.validate());
        }
        [TestMethod]
        public void TestNumber()
        {
            _validator.hasNumber();
            Assert.IsTrue(_validator.validate());
        }
        [TestMethod]
        public void TestSpecialCharacter()
        {
            _validator.hasSpecialCharacter();
            Assert.IsTrue(_validator.validate());
        }
        [TestMethod]
        public void TestRepeatedCharacter()
        {
            _validator.hasRepeatedCharacter();
            Assert.IsTrue(_validator.validate());
        }
        [TestMethod]
        public void TestSize()
        {
            _validator.sizeValidation();
            Assert.IsTrue(_validator.validate());
        }

    }
}
