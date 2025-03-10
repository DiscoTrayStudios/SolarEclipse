﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolarEclipse.Models
{
	public class Volunteer
	{
		public int VolunteerID { get; set; }
		[Required]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }
		[Required]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }
		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[Required]
		public int VolunteerPositionID { get; set; }
		public VolunteerPosition Position { get; set; }
	}
}
