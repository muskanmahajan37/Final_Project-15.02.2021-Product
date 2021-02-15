using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetById(int id);
         List<Product> GetByCategory(int id);
        List<Product> GetByUnitsPrice(decimal min, decimal max);
        void Add(Product product);
        List<ProductDetailDTOs> GetProductDetail();

        


    }

}
