using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UNDPSerbia.Models;
using UNDPSerbia.Dtos;
using AutoMapper;

namespace UNDPSerbia.Controllers.Api
{
    public class EmployeesController : ApiController
    {
        private ApplicationDbContext _context;
        public EmployeesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET /api/employees
        
        public IEnumerable<EmployeeDto> GetEmployees()
        {
            return _context.Employees.ToList().Select(Mapper.Map<Employee, EmployeeDto>);
        }

        // GET /api/employees/1
        
        public IHttpActionResult GetEmployee(int id)
        {
            var employee = _context.Employees.SingleOrDefault(e => e.Id == id);

            if (employee == null)
                return NotFound();

            return Ok(Mapper.Map<Employee,EmployeeDto>(employee));
        }

        // POST /api/employees
        [Authorize(Roles = RoleName.CanManageEmployees)]
        [HttpPost]
        public IHttpActionResult CreateEmployee(EmployeeDto employeeDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var employee = Mapper.Map<EmployeeDto, Employee>(employeeDto);
            _context.Employees.Add(employee);
            _context.SaveChanges();

            employeeDto.Id = employee.Id;

            return Created(new Uri(Request.RequestUri + "/" + employee.Id), employeeDto);
        }

        // PUT /api/employees/1
        [Authorize(Roles = RoleName.CanManageEmployees)]
        [HttpPut]
        public void UpdateEmployee(int id, EmployeeDto employeeDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var employeeInDb = _context.Employees.SingleOrDefault(e => e.Id == id);

            if (employeeInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(employeeDto,employeeInDb);

            /*employeeInDb.FirstName = employee.FirstName;
            employeeInDb.LastName = employee.LastName;
            employeeInDb.Title = employee.Title;
            employeeInDb.DateOfBirth = employee.DateOfBirth;
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
            employeeInDb.PrivateMobile = employee.PrivateMobile;*/

            _context.SaveChanges();
        }

        // DELETE /api/employees/1
        [Authorize(Roles = RoleName.CanManageEmployees)]
        [HttpDelete]
        public void DeleteEmployee (int id)
        {
            var employeeInDb = _context.Employees.SingleOrDefault(e => e.Id == id);

            if (employeeInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Employees.Remove(employeeInDb);
            _context.SaveChanges();
        }
    }
}
