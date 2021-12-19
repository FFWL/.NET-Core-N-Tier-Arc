using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public Category TGetById(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<SelectListItem> GetCategoryList()
        {
            List<SelectListItem> categoryValues = (from x in _categoryDal.GetListAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.categoryName,
                                                       Value = x.categoryID.ToString()
                                                   }).ToList();
            return categoryValues;
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }
        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);
        }
        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }
        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }

    }
}
