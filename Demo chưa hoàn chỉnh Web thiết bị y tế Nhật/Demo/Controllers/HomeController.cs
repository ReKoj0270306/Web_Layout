using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo.Models;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id)
        {
            Student studentBL = new Student();
            Student student = studentBL.GetStudentDetails(id);
            return View();
        }
