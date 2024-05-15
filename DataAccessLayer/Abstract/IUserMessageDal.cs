using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IUserMessageDal : IGenericDal<UserMessage>
	{
		//Kullanıcı mesajlarını kullanıcılarla birlikte listelemek istiyorum.
		//İki tane tabloyu birbiriyle ilişkilendirmek istediğimiz için bu işlemleri yapıyorum.
		public List<UserMessage> GetUserMessagesWithUser();
	}
}
