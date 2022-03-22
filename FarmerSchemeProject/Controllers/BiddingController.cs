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
    public class BiddingController : ControllerBase
    {
        private readonly FarmerSchemeProjectContext db;

        public BiddingController(FarmerSchemeProjectContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult getBidderdata()
        {
            List<Bidder_Welcome> li = new List<Bidder_Welcome>();

            var biddinglist = (from b in db.Biddings
                              join s in db.SellCrops
                              on b.SellId equals s.SellId
                              select new {s.SellId, s.CropType, s.CropName, b.BasePrice, b.CurrentBid, b.BidAmmount }).ToList();

            foreach (var item in biddinglist)
            {
                Bidder_Welcome BD = new Bidder_Welcome();
                BD.SellId = item.SellId;
                BD.CropType = item.CropType;
                BD.CropName = item.CropName;
                BD.BasePrice = item.BasePrice;
                BD.CurrentBid = item.CurrentBid;
                BD.BidAmmount = item.BidAmmount;


                li.Add(BD);


            }
            return Ok(li);
        }

        private IActionResult View(List<Bidding> li)
        {
            throw new NotImplementedException();
        }




        #region 
        [HttpPost]

        /* public IActionResult AddBidding([FromBody] Bidding bidding)
          {
              try
              {
                  if (bidding == null)
                  {
                      return BadRequest("data not entered");
                  }

                  else
                  {
                      db.Biddings.Add(bidding);
                      db.SaveChanges();
                      return Ok("Record Added!!");
                  }
              }

              catch (Exception e)
              {
                  return Ok("Some Error Occured!!!");
              }

          }
          #endregion*/
       public IActionResult AddSellCrop(Bidder_Welcome bidder_Welcome)
        {
            SellCrop sellcrop = new SellCrop();
            sellcrop.CropName = bidder_Welcome.CropName;
            sellcrop.CropType = bidder_Welcome.CropType;
            sellcrop.FertilizerType = bidder_Welcome.FertilizerType;
            sellcrop.Quantity = bidder_Welcome.Quantity;
            sellcrop.FarmerId = bidder_Welcome.FarmerId;
            sellcrop.SellId = bidder_Welcome.SellId;

            db.SellCrops.Add(sellcrop);



            Bidding bidding = new Bidding();
            bidding.BasePrice = bidder_Welcome.BasePrice;
            bidding.CurrentBid = bidder_Welcome.CurrentBid;
            bidding.BidAmmount = bidder_Welcome.BidAmmount;
            bidding.BidderId = bidder_Welcome.BidderId;
            bidding.BiddingDate = bidder_Welcome.BiddingDate;

            db.Biddings.Add(bidding);
            db.SaveChanges();

            return Ok("Success");

        }

    }
    #endregion
}

   
