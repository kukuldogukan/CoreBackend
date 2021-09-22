using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoriesService
    {
        private ICategoriesDal _categoriesDal;

        public CategoryManager(ICategoriesDal categoriesDal)
        {
            _categoriesDal = categoriesDal;
        }

        public IDataResult<Categories> GetById(int categoryId)
        {
            return new SuccessDataResult<Categories>(_categoriesDal.Get(p => p.CategoryId == categoryId));
        }

        public IDataResult<List<Categories>> GetList()
        {
            return new SuccessDataResult<List<Categories>>(_categoriesDal.GetList().ToList());
        }

        public IDataResult<Categories> GetByCategoryName(string categoryName)
        {
            return new SuccessDataResult<Categories>(_categoriesDal.Get(p => p.CategoryName == categoryName));
        }

        public IResult Add(Categories category)
        {
            _categoriesDal.Add(category);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Categories category)
        {
            _categoriesDal.Delete(category);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IResult Update(Categories category)
        {
            _categoriesDal.Update(category);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
