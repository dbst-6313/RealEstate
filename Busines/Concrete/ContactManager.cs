using Busines.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Concrete
{
    public class ContactManager : IContactService
    {

        IContactDal _ContactDal;

        public ContactManager(IContactDal ContactDal)
        {
            _ContactDal = ContactDal;
        }
        public IResult Add(Contact advert)
        {
            _ContactDal.Add(advert);
            return new SuccessResult();
        }

        public IResult Delete(Contact advert)
        {
            _ContactDal.Delete(advert);
            return new SuccessResult();
        }

        public IDataResult<List<Contact>> GetAll()
        {
            return new SuccessDataResult<List<Contact>>(_ContactDal.GetAll());
        }

        public IDataResult<Contact> GetById(int Id)
        {
            return new SuccessDataResult<Contact>(_ContactDal.Get(p => p.Id == Id));
        }

        public IResult Update(Contact advert)
        {
            _ContactDal.Update(advert);
            return new SuccessResult();
        }
    }
}
