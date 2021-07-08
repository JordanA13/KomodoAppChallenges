using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaims
{
    class ClaimList
    {
        public List<Claim> Claims { get; set; }
        
        public ClaimList()
        {
            Claims = new List<Claim>();
        }

    }
}
