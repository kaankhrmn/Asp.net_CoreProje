using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceService;

        public ServiceManager(IServiceDal serviceService)
        {
            _serviceService = serviceService;
        }

        public List<Service> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Service t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Service t)
        {
            throw new NotImplementedException();
        }

        public Service TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Service t)
        {
            throw new NotImplementedException();
        }
    }
}
