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
            if (product == null) throw new ArgumentNullException(nameof(product));

            product.ID = GenerateId();
            _products.Add(product);

            return product;
        }
        

        public bool Update(Product product)
        {
            if (product == null) return false;

            Product? existing = _products.Find(p => p.ID == product.ID);
            if (existing == null) return false;

            existing.Name = product.Name;
            existing.Category = product.Category;
            existing.Price = product.Price;
            existing.Status = product.Status;
            existing.Stock = product.Stock;
            return true;
        }

        public bool Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) return false;
            var existing = _products.Find(p => p.ID == id);
            if (existing == null) return false;
            return _products.Remove(existing);
        }

        public Product? GetById(string id)
        {
            Product? product = _products.Find(p => p.ID == id);
            return product;
        }

        public List<Product> GetAll()
        {
            return _products.OrderBy(p=>p.Name).ToList();
        }

        public List<Product> Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status)
        {
            List<Product> _filtered = _products.ToList();

            if (!string.IsNullOrWhiteSpace(text))
            {
                _filtered = _filtered
                    .Where(p => p.Name != null && p.Name.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
            }

            if (category is not null)
            {
                _filtered = _filtered.Where(p => p.Category == category).ToList();
            }

            if (status is not null)
            {
                _filtered = _filtered.Where(p => p.Status == status.Value).ToList();
            }

            return _filtered;



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