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
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public List<Portfolio> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Portfolio t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Portfolio t)
        {
            throw new NotImplementedException();
        }

        public Portfolio TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Portfolio t)
        {
            throw new NotImplementedException();
        }
    }
}