using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScheduleAPI.Models;

namespace ScheduleAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/contacts")]
    public class ContactsController : Controller
    {
        [HttpGet]
        public List<Contact> Get()
        {
            return new Contact().GetList();
        }

        //TODO: create, update, delete
    }
}