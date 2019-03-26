// This file is auto generated. Changes to these files will be lost! 
using System;
using System.Collections.Generic;

namespace TexTran.Data.Abstractions.Entities
{
	public class Order
	{
		public Guid Id { get; set; }
		public List<Product> Products { get; set; }
		public decimal Price { get; set; }
	}
}

