

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        //-- Arrange: Set up the test
        //-- Act: Access the member being tested
        //-- Assert: Determine the result

        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 8, 25, 9, 0, 0, new TimeSpan(3, 0, 0))
            };

            //-- Act
            var actual = orderRepository.Retrieve(10);

            //-- Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

        }
    }
}