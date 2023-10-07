using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyApplication.Models
{
	public class Login
	{
		[Required]
        public string LoginUsername { get; set; }
		[Required]
		public string LoginPassword { get; set; }
    }
}