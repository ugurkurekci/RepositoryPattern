using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AboutService : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutService(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public IResult Add(About about)
        {
            _aboutDal.Add(about);
            return new SuccessResult(AllMessages.AboutAdded);
        }

        public IResult Delete(About about)
        {
            _aboutDal.Delete(about);
            return new SuccessResult(AllMessages.AboutDeleted);
        }

        public IDataResult<About> GetAboutByDescription(string aboutDescription)
        {
            return new SuccessDataResult<About>(_aboutDal.Get(p => p.Description == aboutDescription), AllMessages.AboutByDescription);
        }

        public IDataResult<About> GetAboutById(int aboutId)
        {
            return new SuccessDataResult<About>(_aboutDal.Get(p => p.AboutId == aboutId), AllMessages.AboutById);
        }

        public IDataResult<List<About>> GetAll()
        {
            return new SuccessDataResult<List<About>>(_aboutDal.GetAll(), AllMessages.AboutListed);
        }

        public IResult Update(About about)
        {
            _aboutDal.Update(about);
            return new SuccessResult(AllMessages.AboutUpdated);
        }


    }
}
