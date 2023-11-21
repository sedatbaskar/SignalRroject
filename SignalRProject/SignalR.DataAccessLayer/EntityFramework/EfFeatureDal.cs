using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfFeatureDal : GenericRepositories<Feature>, IFeatureDal
    {
        public EfFeatureDal(SignalRContext context) : base(context)
        {
        }
    }
}
