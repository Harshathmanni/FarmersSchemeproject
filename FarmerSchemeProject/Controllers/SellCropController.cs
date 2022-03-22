using FarmerSchemeProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmerSchemeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellCropController : ControllerBase
    {
        private readonly FarmerSchemeProjectContext db;

        public SellCropController(FarmerSchemeProjectContext context)
        {
            db = context;
        }

        [HttpGet]

        public IActionResult Get()
        {

            var sellcrop = db.SellCrops.ToList();

            if (sellcrop != null)
            {
                return Ok(sellcrop);
            }
            else
            {
                return NotFound("data not found");
            }

        }


        [HttpGet("{id}")]
        public IActionResult GetSellCrop(int id)
        {
            var sellcrop = db.SellCrops.Find(id);

            if (sellcrop == null)
            {
                return NotFound();
            }

            return Ok(sellcrop);
            return Ok("added");

        }

        #region 
        [HttpPost]

        public IActionResult AddSellcrop([FromBody] SellCrop sellcrop)
        {
            try
            {
                if (sellcrop == null)
                {
                    return BadRequest("data not entered");
                }

                else
                {
                    db.SellCrops.Add(sellcrop);
                    db.SaveChanges();
                    return Ok("Record Added!!");
                }
            }

            catch (Exception e)
            {
                return Ok("Some Error Occured!!!");
            }

        }
        #endregion
    }
}


 

