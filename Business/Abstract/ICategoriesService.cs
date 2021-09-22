using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoriesService
    {
        IDataResult<Categories> GetById(int categoryId);
        IDataResult<List<Categories>> GetList();
        IDataResult<Categories> GetByCategoryName(string categoryName);
        IResult Add(Categories category);
        IResult Delete(Categories category);
        IResult Update(Categories category);
    }
}
