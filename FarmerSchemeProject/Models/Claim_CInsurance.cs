using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace FarmerSchemeProject.Models
{
    [DataContract]
    public class Claim_CInsurance
    {
        [Key]
        [DataMember]
        public int PolicyNo { get; set; } //claiminsuance
        [DataMember]
        public string NameofInsure { get; set; }
        [DataMember]
        public DateTime DateOfLoss { get; set; }
        [DataMember]
        public string CauseofLoss { get; set; }
        [DataMember]
        public string InsuranceCompany { get; set; }//insurance
        [DataMember]
        public int? SumInsured { get; set; }
        [DataMember]
        public string Area { get; set; }
        [DataMember]
        public String CropName { get; set; }
        [DataMember]
        public int SumInsuredperhectar { get; set; }
        [DataMember]
        public int SharePremium { get; set; }
        [DataMember]
        public int PremiumAmmount { get; set; }
        [DataMember]
        public int UserId { get; set; }





    }
}
