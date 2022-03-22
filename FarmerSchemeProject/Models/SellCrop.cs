using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#nullable disable

namespace FarmerSchemeProject.Models
{
    [DataContract]
    public partial class SellCrop
    {
        public SellCrop()
        {
            Biddings = new HashSet<Bidding>();
            SoldHistories = new HashSet<SoldHistory>();
        }
        [DataMember]
        public string CropName { get; set; }
        [DataMember]
        public string CropType { get; set; }
        [DataMember]
        public string FertilizerType { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public string SoilPhcertificate { get; set; }
        [DataMember]
        public int FarmerId { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public int SellId { get; set; }

        public virtual LandDetail Farmer { get; set; }
        public virtual ICollection<Bidding> Biddings { get; set; }
        public virtual ICollection<SoldHistory> SoldHistories { get; set; }
    }
}
