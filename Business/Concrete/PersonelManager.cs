using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Core.Utilities.Results;

namespace Business.Concrete
{
    public class PersonelManager:IPersonelService
    {
        IPersonelDal _personelDal;
        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public IDataResult<List<Personel>> GetAll()
        {
            return new SuccessDataResult<List<Personel>>(_personelDal.GetAll());
        }
    }
}
