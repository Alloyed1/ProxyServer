using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyServer.Models
{
	public class User : IdentityUser
	{
		public string FirstName { get; set; }
		public string Bitcoin { get; set; }
		public float Balance { get; set; }
	}
}
