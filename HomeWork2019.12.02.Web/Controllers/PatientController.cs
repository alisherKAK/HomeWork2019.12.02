using HomeWork2019._12._02.DataAccess;
using HomeWork2019._12._02.Models;
using HomeWork2019._12._02.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork2019._12._02.Web.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPost(Patient patient)
        {
            DbRepository<Patient> repository = new DbRepository<Patient>(new HospitalContext());

            repository.Add(patient);

            return Redirect("/DiseasHistory/LookToPatients");
        }
    }
}