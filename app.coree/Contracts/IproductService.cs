using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Contracts
{
    public interface IproductService
    {
         Product Add(Product product);
         bool Update(Product product);
         bool Delete(string id);

         Product GetById(string id);
         List<Product> GetAll();

         List<Product> Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status);
    }
}
