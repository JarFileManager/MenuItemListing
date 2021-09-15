using MenuItemListing.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        // GET api/<MenuItemController>
        [HttpGet()]
        public List<MenuItem> GetMenu()
        {
            var list = new List<MenuItem>
            {
                new MenuItem{Id = 1, Name = "Phone", Active = true, DateOfLaunch = Convert.ToDateTime("2020/10/12"), FreeDelivery = false, Price = 18999},
                new MenuItem{Id = 2, Name = "Laptop", Active = true, DateOfLaunch = Convert.ToDateTime("2021/10/12"), FreeDelivery = false, Price = 38999}

            };

            return list;
        }

        // GET api/<MenuItemController>/5
        [HttpGet("{id}")]
        public IActionResult GetMenuById(int id)
        {
            var list = GetMenu();
            var menu = list.Find(m => m.Id == id);
            if (menu != null)
                return Ok(menu);
            return NotFound("Incorrect menu item id chosen. Please choose the appropriate Id");
        }

        
    }
}
