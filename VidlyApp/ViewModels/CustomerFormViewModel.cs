using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VidlyApp.Models;

namespace VidlyApp.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
        public string Ttitle
        {
            get
            {
                if (Customer != null && Customer.Id != 0)
                    return "Edit Customer";
                return "New Customer";
            }
            set { }
        }
    }
}
