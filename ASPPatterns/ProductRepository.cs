using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPPatterns
{
    public interface IProductRepository
    {
        IList<Product> GetAllProducts(int category);
    }
    public class ProductRepository : IProductRepository
    {

        public IList<Product> GetAllProducts(int category)
        {
            throw new NotImplementedException();
        }
    }
}