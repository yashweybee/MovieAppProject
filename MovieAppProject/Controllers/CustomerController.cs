using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieAppProject.Models;
using System.Data.Entity;
using System.Web.UI.HtmlControls;
using MovieAppProject.ViewModels;


namespace MovieAppProject.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customer
        //[Authorize]
        public ActionResult Index()
        {
            var customer = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customer);
        }
        public ActionResult Details(int id)
        {
            var cus = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (cus == null)
            {
                return HttpNotFound();
            }
            return View(cus);
        }

        public ActionResult CustomerForm()
        {
            var MembershipType = _context.MembershipType.ToList();
            var viewModel = new CustomerFormVIewModel()
            {
                Customer = new Customer(), //added for hidden field validation error messsage
                MembershipTypes = MembershipType
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormVIewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipType.ToList()
                };
                return View("CustomerForm", viewModel);
            }


            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);

            }
            else
            {
                var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == customer.Id);

                customerInDb.CName = customer.CName;
                customerInDb.DOB = customer.DOB;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;

                //TryUpdateModel(customerInDb);
                //Mapper.Map(customer, customerInDb);
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            var viewModel = new CustomerFormVIewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipType.ToList()
            };
            return View("CustomerForm", viewModel);
        }
    }
}