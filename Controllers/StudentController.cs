using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCApplication.Models;
namespace MyMVCApplication.Controllers
{
    //created by add new controller-> select mvc empty
    public class StudentController : Controller
    {
        List<Student> lstStudents = new List<Student>();
        // GET: Student
        public ActionResult Index()
        {
            
            lstStudents.Add(new Student { Id = 3208595, Name = "miki", Age = 10 });
            lstStudents.Add(new Student { Id = 5849655, Name = "bgfdhf", Age = 20 });
            lstStudents.Add(new Student { Id = 3208595, Name = "hdhfh", Age = 30 });
            lstStudents.Add(new Student { Id = 8124789, Name = "rter", Age = 40 });
            lstStudents.Add(new Student { Id = 3697458, Name = "jhhg", Age = 50 });
            //return Content("created by add new controller-> select mvc empty");

            return View(lstStudents);
        }
        public ActionResult Edit(int id)
        {
            var std = lstStudents.Where(x => x.Id == id);

            return View(std);
        }
        public string Search(int id=-1,string name="",int age=-1)
        {
            try
            {
            return "created by add new controller-> select mvc empty";

            }

            catch (Exception ex)
            {
                return  ex.Message;
            }
        }
    }
}