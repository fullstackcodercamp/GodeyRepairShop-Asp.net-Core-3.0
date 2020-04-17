using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GodeyCarRepairShop.Models;
using GodeyCarRepairShop.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GodeyCarRepairShop.Controllers
{
    public class OrdersController : Controller
    {

        public OrdersController(CarRepairDbContext database)
        {
            Database = database;
        }

        public CarRepairDbContext Database { get; }


        public IActionResult NewOrder(Guid Id)
        {
            var service = Database.Services.Find(Id);

            if (service == null)
            {
                return NotFound("Service Not Offered");
            }


            var customerOrder = new CustomerOrder()
            {
                ServiceId = Id,
                Service = service,
                Customer = new Customer()
            };

            return View(customerOrder);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewOrder(CustomerOrder customerOrder)
        {
            if (ModelState.IsValid)
            {

                Database.Customers.Add(customerOrder.Customer);
                Database.SaveChanges();

                var service = Database.Services.Find(customerOrder.ServiceId);
                var customerId = Database.Customers
                        .FirstOrDefault(x => x.FirstName == customerOrder.Customer.FirstName && x.Email == customerOrder.Customer.Email).CustomerId;
               
                var newOrder = new Order()
                {
                    TotalCost = service.Cost,
                    TotalPaid = 0,
                    Discount = 0,
                    Status = "InProgress",
                    IsPaid = false,
                    ServiceId = service.ServiceId,
                    CustomerId = customerId

                };
                Database.Orders.Add(newOrder);
                Database.SaveChanges();

                return RedirectToAction("Index", "Home");

            }

            return View(customerOrder);
        }



        public IActionResult PendingOrders()
        {
            var orderStatus = Database.Orders.Where(x => x.Status == "InProgress")
                .Include(x => x.Customer).ToList();

            return View(orderStatus);
        }


        public IActionResult CompletedOrders()
        {
            var orderStatus = Database.Orders.Include(x => x.Customer)
                .Where(x => x.Status != "InProgress").ToList();

            return View(orderStatus);
        }



        public IActionResult CompleteOrder(Guid Id)
        {
            var order = Database.Orders.FirstOrDefault(x => x.ServiceId == Id);
            if (order == null)
            {
                return NotFound("No Order Found");
            }
            return View(order);
        }


        [HttpPost]
        public IActionResult CompleteOrder(Order customerService)
        {
            if (ModelState.IsValid)
            {

                if ((customerService.TotalPaid + customerService.Discount) >= customerService.TotalCost)
                {
                    customerService.IsPaid = true;
                    customerService.Status = "Completed";

                }
                else
                {
                    customerService.IsPaid = false;
                    customerService.Status = "InProgress";
                }
                Database.Orders.Update(customerService);
                Database.SaveChanges();
                return RedirectToAction("PendingOrders");
            }
            return View(customerService);
        }



    }
}