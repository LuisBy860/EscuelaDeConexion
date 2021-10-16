using EsculaDeConexion.Models;
using EsculaDeConexion.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EsculaDeConexion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
        
            CoursesRepository  coursesRepository = new CoursesRepository();
      
           var ListOfData =  coursesRepository.ListDataCourses();
           
          
          return View(ListOfData);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}