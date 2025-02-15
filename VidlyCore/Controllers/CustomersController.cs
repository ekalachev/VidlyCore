﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VidlyCore.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VidlyCore.Controllers
{
    public class CustomersController : Controller
    {
        private readonly VidlyDbContext _context;
        private readonly Random _random;

        public CustomersController(VidlyDbContext context)
        {
            _context = context;
            _random = new Random();
        }

        public IActionResult Index()
        {
            return View(_context.Customers.Include(x => x.MembershipType).ToList());
        }

        public IActionResult Customer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(x => x.Id == id);

            if (customer == null)
                return new NotFoundResult();

            return View(customer);
        }
    }
}
