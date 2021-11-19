using Business.Abstract;
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
    public class RankService : IRankService
    {
        private readonly IRankDal _rankDal;

        public RankService(IRankDal rankDal)
        {
            _rankDal = rankDal;
        }

        public IResult Add(Rank rank)
        {
            _rankDal.Add(rank);
            return new SuccessResult();
        }

        public IResult Delete(Rank rank)
        {
            _rankDal.Delete(rank);
            return new SuccessResult();
        }

        public IDataResult<List<Rank>> GetAll()
        {
            return new SuccessDataResult<List<Rank>>(_rankDal.GetAll());
        }

        public IDataResult<Rank> GetRankById(int rankId)
        {
            return new SuccessDataResult<Rank>(_rankDal.Get(o => o.Rankıd == rankId));
        }

        public IDataResult<Rank> GetRankByName(string rankName)
        {
            return new SuccessDataResult<Rank>(_rankDal.Get(x => x.RankName == rankName));
        }

        public IResult Update(Rank rank)
        {
            _rankDal.Update(rank);
            return new SuccessResult();
        }
    }
}
