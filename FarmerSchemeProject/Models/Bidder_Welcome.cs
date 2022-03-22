using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace FarmerSchemeProject.Models
{
    [DataContract]
    public class Bidder_Welcome
    {
        
            [DataMember]
            public int SellId { get; set; }
            [DataMember]
            public string CropName { get; set; }
            [DataMember]
            public string CropType { get; set; }
            [DataMember]
            public int BasePrice { get; set; } //bidding
            [DataMember]
            public int CurrentBid { get; set; }
            [DataMember]
            public int BidAmmount { get; set; }
        [DataMember]
        public string FertilizerType { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public int FarmerId { get; set; }
        [DataMember]
        public int BidderId { get; set; }
        [DataMember]
        public DateTime BiddingDate { get; set; }


    }





    
}

