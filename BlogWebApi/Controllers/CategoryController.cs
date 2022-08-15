using BusinessLayer.Concrete;
using DataAccessLayer.Data;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApi.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]

    public class CategoryController : ControllerBase
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        [HttpGet]
        public IActionResult CategoryList()
        {

            var list = cm.List(x => x.Status == true);

            if (list == null)
            {
                return BadRequest();
            }

            return Ok(list);
        }

        [HttpGet("{id}")]

        public IActionResult GetOneCategory(int id)
        {
            var category = cm.GetById(id);
            if (category == null)
            {
                return BadRequest();
            }
            return Ok(category);
        }

        [HttpPost]
        public IActionResult CreateCategory(Category data)
        {
            if (data == null)
            {
                return BadRequest();
            }
            cm.Add(data);
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var category = cm.GetById(id);

            if (category == null)
            {
                return BadRequest();
            }
            cm.Delete(category);
            return Ok(category);
        }

        [HttpPut]
        public IActionResult UpdateCategory(Category data)
        {
            
            if (data==null)
            {
                return BadRequest();
            }

            cm.Update(data);
            return Ok(data);
        }
       
    }
}
