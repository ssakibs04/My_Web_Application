﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyApplication.Models
{
	public class SignUp
	{
		[Required]
        public string Name { get; set; }
		[Required]
		public string Username { get; set; }
		[Required]
		public string Password { get; set; }
    }
}