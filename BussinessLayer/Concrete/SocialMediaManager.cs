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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMediaService;

        public SocialMediaManager(ISocialMediaDal socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public List<SocialMedia> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(SocialMedia t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(SocialMedia t)
        {
            throw new NotImplementedException();
        }

        public SocialMedia TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SocialMedia t)
        {
            throw new NotImplementedException();
        }
    }
}
