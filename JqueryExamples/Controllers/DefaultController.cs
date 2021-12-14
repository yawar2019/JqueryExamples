using JqueryExamples.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;

namespace JqueryExamples.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DynamicTextBox()
        {
            return View();
        }

        public ActionResult DynamicTextBoxCreate()
        {
            CustomControlProperty cp1 = new Models.CustomControlProperty();
            cp1.PropertyId = 1;
            cp1.PropertyName = "EmpName";
            cp1.PropertyValue = "John";

            CustomControlProperty cp2 = new Models.CustomControlProperty();
            cp2.PropertyId = 2;
            cp2.PropertyName = "EmpSalary";
            cp2.PropertyValue = "250000";


            List<CustomControlProperty> listobj = new List<Models.CustomControlProperty>();
            listobj.Add(cp1);
            listobj.Add(cp2);

            return Json(listobj.OrderByDescending(s=>s.PropertyId),JsonRequestBehavior.AllowGet);
        }


        
        [HttpGet]
        public ActionResult DynTxtCreateSecondMethod()
        {
            CustomControlProperty cp1 = new Models.CustomControlProperty();
            cp1.PropertyId = 1;
            cp1.PropertyName = "EmpName";
            cp1.PropertyValue = "John";

            CustomControlProperty cp2 = new Models.CustomControlProperty();
            cp2.PropertyId = 2;
            cp2.PropertyName = "EmpSalary";
            cp2.PropertyValue = "250000";

            CustomControlProperty cp3 = new Models.CustomControlProperty();
            cp3.PropertyId = 3;
            cp3.PropertyName = "EmpDesignation";
            cp3.PropertyValue = "Software Developer";


            List<CustomControlProperty> listobj = new List<Models.CustomControlProperty>();
            listobj.Add(cp1);
            listobj.Add(cp2);
            listobj.Add(cp3);

            return View(listobj);
        }


        [HttpPost]  
        public ActionResult SaveEmployee(EmployeeModel emp)
        {
            return View();
        }




        [HttpGet]
        public ActionResult DynTxtCreateUsingDb()
        {
            SqlConnection con = new SqlConnection(@"Data Source=AZAM-PC\SQLEXPRESS;Initial catalog=Employee;Integrated Security=true");
           var CustomControl= con.Query<CustomControlProperty>("usp_getCustomProperty", commandType: CommandType.StoredProcedure).ToList();
            
            return View("DynTxtCreateSecondMethod", CustomControl);
        }


        [HttpPost]
        public ActionResult DynTxtCreateUsingDb(EmployeeModel emp)
        {
            return View();
        }


























    }
}