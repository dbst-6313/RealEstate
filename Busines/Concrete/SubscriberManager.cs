using Busines.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Concrete
{
    public class SubscriberManager : ISubscriberService
    {

        ISubscriberDal _SubscriberDal;

        public SubscriberManager(ISubscriberDal SubscriberDal)
        {
            _SubscriberDal = SubscriberDal;
        }
        public IResult Add(Subscriber advert)
        {
            _SubscriberDal.Add(advert);
            return new SuccessResult();
        }

        public IResult Delete(Subscriber advert)
        {
            _SubscriberDal.Delete(advert);
            return new SuccessResult();
        }

        public IDataResult<List<Subscriber>> GetAll()
        {
            return new SuccessDataResult<List<Subscriber>>(_SubscriberDal.GetAll());
        }

        public IDataResult<Subscriber> GetById(int Id)
        {
            return new SuccessDataResult<Subscriber>(_SubscriberDal.Get(p => p.Id == Id));
        }

        public IResult Update(Subscriber advert)
        {
            _SubscriberDal.Update(advert);
            return new SuccessResult();
        }
    }
}
