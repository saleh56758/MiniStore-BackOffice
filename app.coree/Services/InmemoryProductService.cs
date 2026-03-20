using App.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using App.Core.Models;
using App.Core.Utilities;
using System.Linq;

namespace App.Core.Services
{
    public class InmemoryProductService : IproductService
    {
        private readonly List<Product> _products;

        public InmemoryProductService()
        {
            _products = new List<Product>();
            GenerateFakeProducts();
        }

        public Product Add(Product product)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product product)
        {
            return false;
        }

        public bool Delete(string id)
        {
            return false;
        }

        public Product GetById(string id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products.OrderBy(p=>p.Name).ToList();
        }

        public List<Product> Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status)
        {
            throw new NotImplementedException();
        }

        private void GenerateFakeProducts()
        {
            _products.Clear();

            _products.Add(new Product
            {
                ID = GenerateId(),
                Name = "Laptop",
                Category = ProductCategoryEnum.Electronics,
                Price = 250000.90m,
                Status = ProductStatusEnum.Active,
                Stock = 10
            });
            _products.Add(new Product
            {
                ID = GenerateId(),
                Name = "Jacket",
                Category = ProductCategoryEnum.Clothing,
                Price = 4500.50m,
                Status = ProductStatusEnum.Active,
                Stock = 50
            });
            _products.Add(new Product
            {
                ID = GenerateId(),
                Name = "Pen",
                Category = ProductCategoryEnum.Stationary,
                Price = 45.50m,
                Status = ProductStatusEnum.Active,
                Stock = 50
            });
        }

      
        private string GenerateId()
        {
            // e.g., P-1A2B3C
            return "P-" + Guid.NewGuid().ToString("N").Substring(0, 6);
        }
    }
}