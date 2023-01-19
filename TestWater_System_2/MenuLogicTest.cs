using MenuWater_System_2;

namespace TestWater_System_2
{
    [TestClass]
    public class MenuLogicTest
    {
        [TestMethod]
        public void GetOptionReturnsRegisterAssociateOption()
        {
            List<string> ExpectedOptions = new() { "1. Register associate" };
            string result = MenuLogic.GetOption(MainMenu.Options, 0);
            Assert.AreEqual(ExpectedOptions[0], result);
        }

        [TestMethod]
        public void GetOptionReturnsFirstNameString()
        {
            List<string> ExpectedOptions = new() { "First name: ", "Last name:", "Meter ID: " };
            string result = MenuLogic.GetOption(RegisterAssociateMenu.Options, 0);
            Assert.AreEqual(ExpectedOptions[0], result);
        }

        [TestMethod]
        public void GetOptionReturnsLastNameString()
        {
            List<string> ExpectedOptions = new() { "First name: ", "Last name:", "Meter ID: " };
            string result = MenuLogic.GetOption(RegisterAssociateMenu.Options, 1);
            Assert.AreEqual(ExpectedOptions[1], result);
        }

        [TestMethod]
        public void GetOptionReturnsMeterIDString()
        {
            List<string> ExpectedOptions = new() { "First name: ", "Last name:", "Meter ID: " };
            string result = MenuLogic.GetOption(RegisterAssociateMenu.Options, 2);
            Assert.AreEqual(ExpectedOptions[2], result);
        }

        [TestMethod]
        public void CanConvertToIntWhenMeterIdIsNotANumberReturnsFalse()
        {
            string WrongMeterId = "Not a number";
            Assert.IsFalse(MenuLogic.CanConvertToInt(WrongMeterId));
        }

        [TestMethod]
        public void CanConvertToIntWhenMeterIdIsANumberReturnsTrue()
        {
            string ValidMeterId = "123456";
            Assert.IsTrue(MenuLogic.CanConvertToInt(ValidMeterId));
        }
    }
}