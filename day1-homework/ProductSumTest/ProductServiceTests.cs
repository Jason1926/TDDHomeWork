using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductSum;
using System.Collections.Generic;

namespace ProductSumTest
{
    [TestClass]
    public class ProductServiceTests
    {
        [TestMethod]
        public void CalculateCostSumTest()
        {
            //arrange
            string ItemName = "Cost";
            int BatchAmount = 3;

            var stubDao = new StubProductDao();
            var target = new ProductService(stubDao);

            //act
            var actual = target.CalculateSum(ItemName, BatchAmount);

            //expected
            var expected = new List<int>() { 6, 15, 24, 21 };

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateRevenueSumTest()
        {
            //arrange
            string ItemName = "Revenue";
            int BatchAmount = 4;

            var stubDao = new StubProductDao();
            var target = new ProductService(stubDao);

            //act
            var actual = target.CalculateSum(ItemName, BatchAmount);

            //expected
            var expected = new List<int>() { 50, 66, 61 };

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    public class StubProductDao : IProductDao
    {
        public List<Product> GetAll()
        {
            //塞入假資料
            List<Product> StubProducts = new List<Product>();
            StubProducts.Add(new Product(1, 1, 11, 21));
            StubProducts.Add(new Product(2, 2, 12, 22));
            StubProducts.Add(new Product(3, 3, 13, 23));
            StubProducts.Add(new Product(4, 4, 14, 24));
            StubProducts.Add(new Product(5, 5, 15, 25));
            StubProducts.Add(new Product(6, 6, 16, 26));
            StubProducts.Add(new Product(7, 7, 17, 27));
            StubProducts.Add(new Product(8, 8, 18, 28));
            StubProducts.Add(new Product(9, 9, 19, 29));
            StubProducts.Add(new Product(10, 10, 21, 30));
            StubProducts.Add(new Product(11, 11, 21, 31));

            return StubProducts;
        }
    }
}
