//This code is auto generated. Changes to this file will be lost!
using System;
using TexTran.Data.Abstractions.Entities;

namespace TexTran.Data.Abstractions.Interfaces
{
	public interface IUserRepository
	{
		void Add(User user);

		void Delete(User user);

		void Edit(User user);

		User GetById(Guid id);

		User[] GetAll();

		void SaveChanges();
	}
}

