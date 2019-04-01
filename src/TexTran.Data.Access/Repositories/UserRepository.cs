//This code is auto generated. Changes to this file will be lost!
using System;
using System.Linq;
using TexTran.Data.Abstractions.Interfaces;
using TexTran.Data.Abstractions.Entities;
using TextTran.Data.Access.Context;

namespace TexTran.Data.Access.Repositories
{
	public class UserRepository: IUserRepository
	{
		private readonly TexTranContext _context;

		public UserRepository(TexTranContext context)
		{
			_context = context;
		}

		public void Add(User user)
		{
			_context.Users.Add(user);
		}

		public void Delete(User user)
		{
			_context.Users.Remove(user);
		}

		public void Edit(User user)
		{
			var editedEntity = _context.Users.FirstOrDefault(e => e.Id == user.Id);
			editedEntity = user;
		}

		public User GetById(Guid id)
		{
			return _context.Users.FirstOrDefault(e => e.Id == id);
		}

		public void SaveChanges() => _context.SaveChanges();
	}
}

