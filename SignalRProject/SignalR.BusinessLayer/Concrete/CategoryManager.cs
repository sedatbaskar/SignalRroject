using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    internal class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public void TAdd(Category entity)
        {
            _categorydal.Add(entity);
        }

        public void TDelete(Category entity)
        {
            _categorydal.Delete(entity);
        }

        public Category TGetById(int id)
        {
            return _categorydal.GetById(id);
        }

        public List<Category> TGetListAll()
        {
            return _categorydal.GetListAll();
        }

        public void TUpdate(Category entity)
        {
            _categorydal.Update(entity);
        }
    }
}
