using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.net_CoreProje.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        UserMessageManager uMessageManager = new UserMessageManager(new EfUserMessageDal());

        public IViewComponentResult Invoke()
        {
            var values = uMessageManager.GetUserMessagesWithUserService();
            return View(values);
        }

    }
}
