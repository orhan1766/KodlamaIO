using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        private List<Category> _categories;
        public CategoryDal()
        {
            Category category1 = new Category { Id = 1 , Name="Yazılım Geliştirme"};
            Category category2 = new Category { Id = 2, Name = "Mülakat Teknikleri" };

            List<Category> categories = new List<Category> { category1, category2 };
            _categories = categories;
        }
        public void Add(Category entity)
        {
            _categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            _categories.Remove(entity);
        }

        public Category Get(int id)
        {
            return _categories.Where(c=>c.Id == id).FirstOrDefault();
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category entity)
        {
            _categories.Where(c => c.Id == entity.Id).FirstOrDefault().Name = entity.Name;
        }
    }
}
