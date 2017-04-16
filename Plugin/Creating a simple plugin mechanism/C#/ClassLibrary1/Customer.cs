using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    public class Customer
    {
		public string LastName { get; set; } = "Müller";
		public string FirstName { get; set; } = "Heinz";
		public string Street { get; set; } = "Tichtelgasse 4";
		public string PostCode { get; set; } = "1120";
		public string City { get; set; } = "Wien";
		public bool IsSatisfied { get; set; } = true;
	}
}
