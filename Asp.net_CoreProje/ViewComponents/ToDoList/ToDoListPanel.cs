using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.net_CoreProje.ViewComponents.ToDoList
{
	public class ToDoListPanel: ViewComponent
	{
		ToDoListManager toDoListManager= new ToDoListManager(new EfToDoListDal());

		public IViewComponentResult Invoke()
		{
			var values = toDoListManager.GetList();
			return View(values);
		}

	}
}
