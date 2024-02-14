using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        //GenericRepository<Category> repo = new GenericRepository<Category>();

        //public List<Category> GetAll()
        //{
        //    return repo.GetList();
        //}

        //public void CategoryAdd(Category category)
        //{
        //    repo.Add(category); 
        //}

        ICategoryDal _categgoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
                _categgoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categgoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categgoryDal.Delete(category);
        }

        public List<Category> GetList()
        {
            return _categgoryDal.GetList();
        }

        public void Update(Category category)
        {
            _categgoryDal.Update(category);
        }
    }
}
