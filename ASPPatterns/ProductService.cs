using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPPatterns
{
    public interface ICacheStorage
    {
        void Remove(string key);
        void Store(string key, object data);
        T Retrieve<T>(string key);

    }
    public class ProductService
    {
        private ICacheStorage _cacheStorage;
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository,
            ICacheStorage cacheStorage)
        {
            _cacheStorage = cacheStorage;
            _productRepository = productRepository;
        }

        public IList<Product> GetAllProducts(int category)
        {
            IList<Product> products;
            string storageKey = String.Format("products_in_category_{0}", category);
            products = _cacheStorage.Retrieve<IList<Product>>(storageKey);
            
            if(products ==null)
            {
                products= _productRepository.GetAllProducts(category);

            }

            return products;
        }
    }
}