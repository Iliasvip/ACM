

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        //-- Arrange: Set up the test
        //-- Act: Access the member being tested
        //-- Assert: Determine the result

        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Set of 4 mini Sunflowers",
                CurrentPrice = 15.96M
            };


            //-- Act
            var actual = productRepository.Retrieve(2);

            //-- Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);

        }
    }
}