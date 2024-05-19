using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
	public class AnnouncementManager : IAnnouncementService
	{
		IAnnouncementDal _announcementDal;

		public AnnouncementManager(IAnnouncementDal announcementDal)
		{
			this._announcementDal = announcementDal;
		}

		public List<Announcement> GetList()
		{
			return _announcementDal.GetList();
		}

		public void TAdd(Announcement t)
		{
			_announcementDal.Insert(t);
		}

		public void TDelete(Announcement t)
		{
			_announcementDal.Delete(t);
		}

		public Announcement TGetById(int id)
		{
			return _announcementDal.GetById(id);
		}

		public void TUpdate(Announcement t)
		{
			_announcementDal.Update(t);
		}
	}
}
