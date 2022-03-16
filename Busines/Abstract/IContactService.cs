using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Abstract
{
    public interface IContactService
    {
        IResult Add(Contact contact);
        IResult Update(Contact contact);
        IResult Delete(Contact contact);
        IDataResult<List<Contact>> GetAll();
        IDataResult<Contact> GetById(int Id);
    }
}
