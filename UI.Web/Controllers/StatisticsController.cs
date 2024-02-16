using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    public class StatisticsController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
        HeadingManager headingManager = new HeadingManager(new EFHeadingDal());
        WriterManager writerManager = new WriterManager(new EFWriterDal());

        public ActionResult Index()
        {
            int statusTrue = categoryManager.GetList().Where(x => x.CategoryStatus).Count();
            int statusFalse = categoryManager.GetList().Where(x => x.CategoryStatus == false).Count();

            var result = statusTrue - statusFalse;

            StatisticsModel statisticsModel = new StatisticsModel();
            statisticsModel.getHeadingCountBySoftware = headingManager.GetList().Where(x => x.CategoryId == 3).Count();
            statisticsModel.getCategoryCount = categoryManager.GetList().Count();
            statisticsModel.getWriterByFilter = writerManager.GetList().Count(x => x.WriterName.Contains("a"));
            statisticsModel.getStatusDifference = result;
            statisticsModel.getMaxHeadingCategory = headingManager.GetList()
                .GroupBy(x => x.CategoryId)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault()
                ?.FirstOrDefault()
                ?.Category.CategoryName;

            return View(statisticsModel);
        }

        [HttpGet]
        public ActionResult GetCategoryCount()
        {
            var result = categoryManager.GetList().Count();
            return View(result);
        }

        [HttpGet]
        public ActionResult GetHeadingCountBySoftware()
        {
            var result = headingManager.GetList().Where(x => x.CategoryId == 3).Count();
            return View(result);
        }

        [HttpGet]
        public ActionResult GetWriterByFilter()
        {
            var result = writerManager.GetList().Count(x => x.WriterName.Contains("a"));
            return View(result);
        }

        [HttpGet]
        public ActionResult GetMaxHeadingCategory()
        {
            var result = headingManager.GetList()
                .GroupBy(x => x.CategoryId)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault()
                ?.FirstOrDefault()
                ?.Category.CategoryName;

            return View(result);
        }

        [HttpGet]
        public ActionResult GetStatusDifference()
        {
            int statusTrue = categoryManager.GetList().Where(x => x.CategoryStatus).Count();
            int statusFalse = categoryManager.GetList().Where(x => x.CategoryStatus == false).Count();

            var result = statusTrue - statusFalse;

            return View(result);
        }
    }
}