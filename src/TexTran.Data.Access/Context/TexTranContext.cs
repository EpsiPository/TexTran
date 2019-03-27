// This code is auto generated. Changes to this file will be lost!
using Microsoft.EntityFrameworkCore;
using TexTran.Data.Abstractions.Entities;

namespace TextTran.Data.Access.Context
{
	public class TextTranContext : DbContext
	{
		public TextTranContext(DbContextOptions options) 
			: base(options) 
		{
		}

		public DbSet<Order> Orders { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<User> Users { get; set; }
	}
}

