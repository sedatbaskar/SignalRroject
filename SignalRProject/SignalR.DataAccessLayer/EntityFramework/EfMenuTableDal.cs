using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfMenuTableDal : GenericRepositories<EfMenuTableDal>, IMenuTableDal
    {
        public EfMenuTableDal(SignalRContext context) : base(context)
        {
        }

        public void Add(MenuTable entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(MenuTable entity)
        {
            throw new NotImplementedException();
        }

        public int MenuTableCount()
        {
          using var context = new SignalRContext();
            return context.MenuTables.Count();
        }

        public void Update(MenuTable entity)
        {
            throw new NotImplementedException();
        }

        MenuTable IGenericDal<MenuTable>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        List<MenuTable> IGenericDal<MenuTable>.GetListAll()
        {
            throw new NotImplementedException();
        }
    }
}
