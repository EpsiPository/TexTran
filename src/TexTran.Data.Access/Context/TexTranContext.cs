// This code is auto generated. Changes to this file will be lost!
using Microsoft.EntityFrameworkCore;
using TexTran.Data.Abstractions.Entities;
using TexTran.Data.Access.Configurations;

namespace TextTran.Data.Access.Context
{
	public class TextTranContext : DbContext
	{
		public TextTranContext(DbContextOptions options) 
			: base(options) 
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new UserConfiguration());
		}

		public DbSet<Group> Groups { get; set; }
		public DbSet<User> Users { get; set; }
	}
}

