using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Models
{
    public class Footer : BaseEntity
    { 
        public string Customer { get; set; }
        public string Company { get; set; }
        public string SocialMedia { get; set; }
        public string Archive { get; set; }
    }
}
