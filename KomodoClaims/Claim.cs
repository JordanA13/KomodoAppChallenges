using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaims
{
    public class Claim
    {
        public int ClaimID { get; set; }
        public string ClaimType { get; set; }
        public string ClaimDescription { get; set; }
        public int ClaimAmount { get; set; }
        public DateTime DatOfTime { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }
        public string Claims { get; internal set; }

        public Claim() { }

        public Claim(int claimID, string claimType, string claimDescription, int claimAmount, DateTime dateOfTime, DateTime dateOfClaim, bool isValid, string claims)
        {
            ClaimID = claimID;
            ClaimType = claimType;
            ClaimDescription = claimDescription;
            ClaimAmount = claimAmount;
            DatOfTime = dateOfTime;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
            Claims = claims;
        }
    }
}

