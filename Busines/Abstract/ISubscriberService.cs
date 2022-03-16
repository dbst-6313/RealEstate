using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Abstract
{
    public interface ISubscriberService
    {
        IResult Add(Subscriber subscribe);
        IResult Update(Subscriber subscribe);
        IResult Delete(Subscriber subscribe);
        IDataResult<List<Subscriber>> GetAll();
        IDataResult<Subscriber> GetById(int Id);
    }
}
