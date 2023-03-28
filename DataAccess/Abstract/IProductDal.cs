using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //I interface | Product hangi tabloya karşılık |
    //Dal : Data Access Layer (Dao da var. object (Java) - hangi tablo olduğunu gösterir) 
    //interface public değil, operasyonları public
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        //ürünleri kategoriye göre listele
        List<Product> GetAllByCategory(int categoryId);
    }
}
