using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonelDal : IPersonelDal
    {
        public void Add(Personel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Personel entity)
        {
            throw new NotImplementedException();
        }

        public Personel Get(Expression<Func<Personel, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Personel> GetAll(Expression<Func<Personel, bool>> filter = null)
        {
            using(NorthwindContext context =new NorthwindContext())
            {
                return context.Personels.ToList();
            }
        }

        public void Update(Personel entity)
        {
            throw new NotImplementedException();
        }
    }
}
