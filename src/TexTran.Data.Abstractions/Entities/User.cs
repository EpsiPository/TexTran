 
// This file is auto generated. Changes to this file will be lost!
using System;
using System.Collections.Generic;
using TextTran.Transformations.Enums;
	
namespace TexTran.Data.Abstractions.Entities
{
	public class User : BaseEntity
	{
			public string FirstName  { get; set; }

		public string LastName  { get; set; }

		public string EmailAddress  { get; set; }

		public DateTimeOffset DateOfBirth  { get; set; }

		public Gender Gender { get; set; }

		public Group Group  { get; set; }

	}
}

