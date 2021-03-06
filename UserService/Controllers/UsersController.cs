﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
//using Microsoft.Azure.ServiceBus;


namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UsersController : ControllerBase
    {
        public readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        
        }

        [HttpGet]
        public IActionResult GetAll()
        {
        return Ok(_context.Users.ToList());
        }


        [HttpPost]
        public IActionResult Add(User p)
        {
            _context.Users.Add(p);
            _context.SaveChanges();

            return Created("/api/users/", p);

        }

    }
}
