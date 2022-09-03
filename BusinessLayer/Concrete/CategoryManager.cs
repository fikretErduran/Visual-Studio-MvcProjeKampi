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

        ICategoryDal _categoydal;

        public CategoryManager(ICategoryDal categoydal)
        {
            _categoydal = categoydal;
        }

        public void CategoryAdd(Category category)
        {
            _categoydal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoydal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoydal.Update(category);   
        }

        public Category GetByID(int id)
        {
            return _categoydal.Get(x => x.CategoryID == id);
        }

        public List<Category> GetList()
        {
            return _categoydal.List();
        }

        //GenericRepository<Category> repo = new GenericRepository<Category>();

        //public List<Category> GetAll()
        //{
        //    return repo.List();
        //}

        // public void CategoryAdd(Category p)
        //{
        //     if (p.CategoryName == "" || p.CategoryName.Length <= 3 ||
        //         p.CategoryDescription == "" || p.CategoryName.Length >= 51)
        //     {
        //         //Hata Mesaji
        //     }
        //     else
        //     {
        //         repo.Insert(p);
        //     }




        //}

    }
}
