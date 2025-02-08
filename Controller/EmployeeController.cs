using ITI_GraduationProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ITI_GraduationProject.Controllers
{
    public class EmployeeController : Controller
    {
        

        /***********************************************************/

        CompanyContext _context;
        public EmployeeController()
        {
            _context = new CompanyContext();
        }
        

        /***********************************************************/

        [HttpGet]
        public IActionResult Index()
        {
            
            var employee = _context.Employees.Include(e => e.Department).ToList();
            return View(employee);
        }


        /**********************************************************/


        [HttpGet]
        public IActionResult Create()
        {
            //list of departments   send them to view   -> ViewModel XXXXX
            var depts = _context.Departments.ToList();
            //view data : dictionary we can send data from action to view in single request

            //
            return View();
        }


        /***********************************************************/


        [HttpPost]
        public IActionResult Create(Employee param)
        {

            _context.Add(param);
            _context.SaveChanges();
            return View("Login");

        }


        /*************************************************************/



        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }



        /*************************************************************/



        [HttpGet]
        public IActionResult Edit(int id)
        {
            var emp = _context.Employees.Find(id);

            //
            var depts = _context.Departments.ToList();
            ViewData["abdallah"] =
                new SelectList(depts, "DeptId", "DeptName", emp.DeptId);
            //

            return View(emp);
        }


        /***************************************************************/



        [HttpPost]
        public IActionResult Edit(Employee param)
        {
            _context.Update(param);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



        /***************************************************************/



        [HttpGet]
        public IActionResult Delete(int id)
        {
            var emp = _context.Employees.Find(id);
            _context.Remove(emp);
            _context.SaveChanges();


            return RedirectToAction("Index");
        }



        /***************************************************************/



        public IActionResult Details(int id)
        {
            var emp = _context.Employees.Find(id);
            return View(emp);
        }

    }
}
