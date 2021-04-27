using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        

        public List<Category> GetAll()
        {
            return _categoryDal.GetALL();
        }
        //Select * from where CategoryId=3
        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }

        List<Category> ICategoryService.GetById(int vategoryId)
        {
            throw new NotImplementedException();
        }
    }
}
