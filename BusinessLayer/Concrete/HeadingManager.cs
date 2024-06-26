﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public void Add(Heading heading)
        {
            _headingDal.Add(heading);   
        }

        public void Delete(Heading heading)
        {
            _headingDal.Update(heading);
           // _headingDal.Delete(heading);
        }

        public Heading GetById(int id)
        {
            return _headingDal.GetById(x => x.HeadingId == id);
        }

        public List<Heading> GetList()
        {
            return _headingDal.GetList();
        }

        public void Update(Heading heading)
        {
            _headingDal.Update(heading);
        }
    }
}
