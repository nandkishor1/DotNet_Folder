using EntityFramework_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFramework_Demo.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo

       [HttpGet]
        public ActionResult Index()
        {

            //Person pr1 = new Person();
            //pr1.ID = 16;
            //pr1.FName = "Aayush";
            //pr1.LName = "Yadav";
            //pr1.DName = "Medical";

            List<Person> lstPerson = new List<Person>()
            {
                new Person {ID=17,FName="Krishna",LName="Yadav",DName="IT"},
                new Person {ID=18,FName="Kisan",LName="Murari",DName="HR"},
                new Person {ID=19,FName="Kanha",LName="Yadav",DName="Marketing"},
                new Person {ID=20,FName="Radhe",LName="Yadav",DName="Accounting"},
            };
           
            using (var context = new ADO_DotNet_DBEntities())
            {
                try
                {
                    //context.People.Add(pr1);
                    //context.People.AddRange(lstPerson);
                    //var result= context.prc_GetPeople();
                    // var result1 = context.People.ToList();

                    var result = context.prc_InsertData(21, "Lakshman", "Yadav", "IT");

                    // context.SaveChanges();
                    int ii = 5;
                }
                catch(Exception ex)
                {
                    string msg = ex.ToString();
                }
                //var query = context.People.Where(s => s.DName == "IT").ToList();
                //var obj1 =context.People.SqlQuery("select * from people where ID=110").ToList();

                 int i = 5;
            }

            return null;
        }
    }
}