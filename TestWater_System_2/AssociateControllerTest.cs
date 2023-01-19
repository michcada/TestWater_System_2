using System.Linq.Expressions;
using Water_System_2;

namespace TestWater_System_2
{
    [TestClass]
    public class AssociateControllerTest
    {
        [TestMethod]
        public void AddAssociateWhenMeterIdIsNotAssignedToAnotherAssociateReturnsMoreThanZero()
        {
            Associate testAssociate = new() 
            {
                Name = "Michelle",
                LastName = "Cadavid",
                MeterId = 123456
            };
            AssociateController myAssociateController = new();
            int result = myAssociateController.AddAssociate(testAssociate);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void AddAssociateWhenMeterIdAssignedToAnotherAssociateThrowsException()
        {
            Associate testAssociate = new()
            {
                Name = "Michelle",
                LastName = "Cadavid",
                MeterId = 123456
            };
            List<Associate> testList = new(){ testAssociate };
            AssociateController myAssociateController = new(testList);
            string expectedMessage = "The meter ID is already registered to another associate";
            string result = "";

            try
            {
                myAssociateController.AddAssociate(testAssociate);
            }
            catch(Exception e)
            {
                result = e.Message;
            }
            Assert.AreEqual(expectedMessage, result);
        }

        [TestMethod]
        public void FindNumberOfDigitsReturnsTheNumberOfDigitsOfAnInt()
        {
            int meterId = 12345;
            AssociateController myAssociateController = new();
            Assert.AreEqual(5, myAssociateController.FindNumberOfDigits(meterId));
        }

        [TestMethod]
        public void AddAssociateWhenMeterIDIsLessThanSixDigitsThrowsException()
        {
            Associate testAssociate = new()
            {
                Name = "Michelle",
                LastName = "Cadavid",
                MeterId = 12345
            };
            AssociateController myAssociateController = new();
            string expectedMessage = "Meter ID has Not A Valid Format";
            string result = "";
            try
            {
                myAssociateController.AddAssociate(testAssociate);
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            Assert.AreEqual(expectedMessage, result);
        }

    }
}