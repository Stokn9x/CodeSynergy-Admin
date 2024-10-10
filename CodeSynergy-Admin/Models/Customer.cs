using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSynergy_Admin.Models
{
	public class Customer
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string Position { get; set; }

		public Customer(string name, string email, string phoneNumber, string position)
		{
			this.Name = name;
			this.Email = email;
			this.PhoneNumber = phoneNumber;
			this.Position = position;
		}
	}
}
