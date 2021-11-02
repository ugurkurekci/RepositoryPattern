using Core.Repository.EntityFramework;
using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAboutDal : IEntityRepositoryBase<About>
    {
        
    }
}
