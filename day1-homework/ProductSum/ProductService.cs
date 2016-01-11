using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ProductSum
{
    public class ProductService
    {
        private IProductDao _ProductDao;

        public ProductService(IProductDao ProductDao)
        {
            this._ProductDao = ProductDao;
        }

        public ProductService()
        {
            this._ProductDao = new ProductDao();
        }

        public List<int> CalculateSum(string ItemName, int BatchAmount)
        {
            //拿出資料集合
            List<Product> Products = _ProductDao.GetAll();

            //決定要加總那一個項目
            List<int> Items = new List<int>();
            switch (ItemName)
            {
                case "Id":
                    Items = Products.Select(p => p.Id).ToList();
                    break;
                case "Cost":
                    Items = Products.Select(p => p.Cost).ToList();
                    break;
                case "Revenue":
                    Items = Products.Select(p => p.Revenue).ToList();
                    break;
                case "SellPrice":
                    Items = Products.Select(p => p.SellPrice).ToList();
                    break;
              }
        
            //計算集合
            List<int> Result = new List<int>();
            for (int i = 0; i < Items.Count / BatchAmount + (Items.Count % BatchAmount == 0 ? 0 : 1); i++)
            {
                Result.Add(Items.Skip(i * BatchAmount).Take(BatchAmount).Sum());
            }

            return Result;
        }
    }

    public class ProductDao : IProductDao
    {
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
