using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
            Console.WriteLine("Ürün Eklendi");
        }

        public List<Product> GetAll()
        {
            //İş kodları 
            //if kodları burada bulunur yetkisi var mı ?
            Console.WriteLine("Ürünler Listelendi");
            
            return _productDal.GetAll();

           
        }

        public List<Product> GetByCategory(int categoryId)
        {
            Console.WriteLine("Kategoriye göre sıralandı");
            var getByCategory= _productDal.GetAll(p => p.CategoryId == categoryId);
            return getByCategory;

           
        }

        public List<Product> GetById(int productId)
        {
            Console.WriteLine("Ürün:");
            var getById = _productDal.GetAll(p => p.ProductId == productId);
            return getById;
           
        }

        public List<Product> GetByUnitsPrice(decimal min, decimal max)
        {
            var getByUnitsPrice = _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
            return getByUnitsPrice;

        }

        public List<ProductDetailDTOs> GetProductDetail()
        {
            return _productDal.GetProductDetail();
        }
    }
}
