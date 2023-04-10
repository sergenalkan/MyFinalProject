using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //I interface | Product hangi tabloya karşılık |
    //Dal : Data Access Layer (Dao da var. object (Java) - hangi tablo olduğunu gösterir) 
    //interface public değil, operasyonları public
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}

//Code refactoring