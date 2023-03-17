using Ex15_Disaheim
namespace UnitTest_Ex_17
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MerchandiseConstructorWorkProperly()

        {

            // Arrange

            Merchandise m = new Merchandise("100");

            // Assert

            Assert.AreEqual("ItemId: 100", m.ToString());

        }
    }
}