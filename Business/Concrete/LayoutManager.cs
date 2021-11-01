﻿using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LayoutManager : ILayoutService
    {
        private ILayoutRepository _layoutRepository;
        public LayoutManager(ILayoutRepository layoutRepository)
        {
            _layoutRepository = layoutRepository;
        }
        public int CreateLayout(int X, int Y)
        {
            if(X>=0 && Y >= 0)
            {
                return _layoutRepository.CreateLayout(X,Y);
            }
            throw new Exception("X and Y can not be less than 0");
        }
        
        public List<Layout> GetLayouts()
        {
            return _layoutRepository.GetLayouts();
        }

        public int GetValueOfLayout(int id, int X, int Y)
        {
            return _layoutRepository.GetValueOfLayout(id,X,Y);
        }
    }
}
