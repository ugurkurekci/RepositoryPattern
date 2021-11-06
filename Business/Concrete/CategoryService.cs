using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            var result = BusinessRules.Run(CheckIfCategoryName(category.CategoryName));

            if (result != null)
            {
                return result;
            }

            _categoryDal.Add(category);
            return new SuccessResult(AllMessages.CategoryAdded);
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(AllMessages.CategoryDeleted);
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), AllMessages.CategoryListed);
        }

        public IDataResult<Category> GetCategoryById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(p => p.CategoryId == categoryId), AllMessages.CategoryById);
        }

        public IDataResult<Category> GetCategoryByName(string categoryName)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(p => p.CategoryName == categoryName), AllMessages.CategoryByName);
        }

        public IResult Update(Category category)
        {
            var result = BusinessRules.Run(CheckIfCategoryName(category.CategoryName));

            if (result != null)
            {
                return result;
            }
            _categoryDal.Update(category);
            return new SuccessResult(AllMessages.CategoryUpdated);
        }



        private IResult CheckIfCategoryName(string categoryName)  /*CategoryRule*/
        {
            var result = _categoryDal.GetAll(p => p.CategoryName == categoryName).Any();
            if (result)
            {
                return new ErrorResult(AllMessages.CategoryCheckName);
            }
            return new SuccessResult();
        }
    }
}
