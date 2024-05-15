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
	public class UserMessageManager : IUserMessageService
	{
		IUserMessageDal _userMessageDal;

		public UserMessageManager(IUserMessageDal userMessageDal)
		{
			this._userMessageDal = userMessageDal;
		}

		public List<UserMessage> GetList()
		{
			return _userMessageDal.GetList();
		}

        public List<UserMessage> GetUserMessagesWithUserService()
        {
			return _userMessageDal.GetUserMessagesWithUser();
        }

        public void TAdd(UserMessage t)
		{
			_userMessageDal.Insert(t);
		}

		public void TDelete(UserMessage t)
		{
			_userMessageDal.Delete(t);
		}

		public UserMessage TGetById(int id)
		{
			return _userMessageDal.GetById(id);
		}

		public void TUpdate(UserMessage t)
		{
			_userMessageDal.Update(t);
		}
	}
}
