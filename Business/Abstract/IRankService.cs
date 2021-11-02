using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRankService
    {
        IDataResult<List<Rank>> GetAll();
        IResult Add(Rank rank);
        IResult Update(Rank rank);
        IResult Delete(Rank rank);
        IDataResult<Rank> GetRankById(int rankId);
        IDataResult<Rank> GetRankByName(string rankName);
    }
}
