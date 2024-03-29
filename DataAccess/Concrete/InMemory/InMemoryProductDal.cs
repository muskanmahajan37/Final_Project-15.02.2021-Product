﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},


                new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=150,UnitsInStock=16},

                new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=66,UnitsInStock=17},

                new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=33,UnitsInStock=18},

                new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=22,UnitsInStock=15}

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
}
        //LINQ -Language ıntegrated Querry
        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            //Gönderdiğim  ürün ıd sine sahip olan listedeki ürünü bul 
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
        public List<Product> GetAllByCategory(int categoryId)
        {
           return  _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAlll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDTOs> GetProductDetail()
        {
            throw new NotImplementedException();
        }
    }
}
