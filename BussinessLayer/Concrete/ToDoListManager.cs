﻿using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
	public class ToDoListManager : IToDoListService
	{
		IToDoListDal _toDoListDal;

		public ToDoListManager(IToDoListDal toDoListDal)
		{
			_toDoListDal = toDoListDal;
		}

		public List<ToDoList> GetList()
		{
			return _toDoListDal.GetList();
		}

		public void TAdd(ToDoList t)
		{
			_toDoListDal.Insert(t);
		}

		public void TDelete(ToDoList t)
		{
			_toDoListDal.Delete(t);
		}

		public ToDoList TGetById(int id)
		{
			return _toDoListDal.GetById(id);
		}

		public void TUpdate(ToDoList t)
		{
			_toDoListDal.Update(t);
		}
	}
}
