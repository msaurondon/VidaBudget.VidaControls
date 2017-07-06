using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VidaControls;

namespace VidaControls
{
    
    // access modifier on the validator class has been changed from Public to Internal.
    // These are currently broken.

    [TestClass]
    public class ValidatorTest
    {
        Validator validator = new Validator();

        [TestMethod]
        public void PassValidateDecimalHundredsTest()
        {
            bool pass = validator.ValidateDecimal("123.45");
            Assert.IsTrue(pass);
        }

        [TestMethod]
        public void PassValidateDecimalTensTest()
        {
            bool pass = validator.ValidateDecimal("12.45");
            Assert.IsTrue(pass);
        }

        [TestMethod]
        public void FailValidateDecimalTest()
        {
            bool pass = validator.ValidateDecimal("A123.00");
            Assert.IsFalse(pass);
        }

        [TestMethod]
        public void PassValidateIntegerTest()
        {
            bool pass = validator.ValidateInteger("23");
            Assert.IsTrue(pass);
        }

        [TestMethod]
        public void FailValidatorIntegerTest()
        {
            bool pass = validator.ValidateInteger("A1");
            Assert.IsFalse(pass);
        }

    }
}
