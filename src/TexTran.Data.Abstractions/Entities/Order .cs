// This file is auto generated. Changes to this file will be lost!
using System;
using System.Collections.Generic;
	
namespace TexTran.Data.Abstractions.Entities
{
	/// <summary>
	/// Description of order
	/// </summary>
	public class Order 
	{
		public Guid Id { get; set; }
			
		public List<Product> Products { get; set; }
			
		public decimal Price { get; set; }
			
		public int? Quantity { get; set; }
			
	}
}

