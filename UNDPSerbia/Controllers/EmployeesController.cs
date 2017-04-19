using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UNDPSerbia.Models;
using UNDPSerbia.ViewModels;

namespace UNDPSerbia.Controllers
{
    public class EmployeesController : Controller
    {
        private ApplicationDbContext _context;
        public EmployeesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Authorize(Roles = RoleName.CanManageEmployees)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new EmployeeFormViewModel
                {
                    Employee = employee
                };

                return View("EmployeeForm", viewModel);
            }

            if (employee.Id == 0)
            {
                employee.LastUpdate = DateTime.Now;
                _context.Employees.Add(employee);
            }
             
            else
            {
                var employeeInDb = _context.Employees.Single(c => c.Id == employee.Id);
                employeeInDb.FirstName = employee.FirstName;
                employeeInDb.LastName = employee.LastName;
                employeeInDb.DateOfBirth = employee.DateOfBirth;
                employeeInDb.Title = employee.Title;
                employeeInDb.IndexNo = employee.IndexNo;
                employeeInDb.LPNumber = employee.LPNumber;
                employeeInDb.LPValidity = employee.LPValidity;
                employeeInDb.ExtensionNo = employee.ExtensionNo;
                employeeInDb.GMCID = employee.GMCID;
                employeeInDb.VanBredaID = employee.VanBredaID;
                employeeInDb.DirectBusinessPhone = employee.DirectBusinessPhone;
                employeeInDb.BusinessMobile = employee.BusinessMobile;
                employeeInDb.Email = employee.Email;
                employeeInDb.Username = employee.Username;
                employeeInDb.Supervisor = employee.Supervisor;
                employeeInDb.Nationality = employee.Nationality;
                employeeInDb.PassportNo = employee.PassportNo;
                employeeInDb.BloodType = employee.BloodType;
                employeeInDb.HomeAddress = employee.HomeAddress;
                employeeInDb.HomePhone = employee.HomePhone;
                employeeInDb.PrivateMobile = employee.PrivateMobile;
                employeeInDb.LastUpdate = DateTime.Now;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Employees");
        }
        [Authorize(Roles = RoleName.CanManageEmployees)]
        public ActionResult Details (int id)
        {
            var employee = _context.Employees.SingleOrDefault(e => e.Id == id);
            if (employee == null)
                return HttpNotFound();
            return View(employee);
        }

        /*public ActionResult Edit (int id)
        {
            var employee = _context.Employees.SingleOrDefault(e => e.Id == id);

            if (employee == null)
                return HttpNotFound();
            var viewModel= new EmployeeViewModel
            {
                //Employee = employee
            };
            return View("New", viewModel);
        }*/
        [Authorize(Roles = RoleName.CanManageEmployees)]
        public ActionResult Edit(int id)
        {
            var employee = _context.Employees.SingleOrDefault(e => e.Id == id);

            if (employee == null)
                return HttpNotFound();

            var viewModel = new EmployeeFormViewModel
            {
                Employee = employee
            };

            return View("EmployeeForm", viewModel);
        }

        [Authorize(Roles = RoleName.CanManageEmployees)]
        public ActionResult New()
        {
            var viewModel = new EmployeeFormViewModel
            {
                Employee = new Employee()
            };
            return View("EmployeeForm", viewModel);
        }

        // GET: Employees
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageEmployees))
                return View("List");

            return View("readOnlyList");
        }
    }
}