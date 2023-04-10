using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet : hazır paketler
    //Dataaccess üstüne sağ tık - Manage nuget - entityframeworkcore.sql-
    //default olsun diye 3.1 seçtik ve install
    //EntityFramework da bir NuGet
    //8. Gün 01.25.10 entity framework kurulumu
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        
    }
}
