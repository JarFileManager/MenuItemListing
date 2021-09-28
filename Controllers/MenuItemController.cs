using MenuItemListing.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        
        [HttpGet("GetMenu")]
        public List<MenuItem> GetMenu()
        {
            var list = new List<MenuItem>
            {
                new MenuItem{Id = 1, Name = "Phone", Active = true, DateOfLaunch = Convert.ToDateTime("2020/12/1"), FreeDelivery = false, Price = 32999},
                new MenuItem{Id = 2, Name = "Laptop", Active = true, DateOfLaunch = Convert.ToDateTime("2021/12/1"), FreeDelivery = false, Price = 78999}

            };

            return list;
        }

        
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
