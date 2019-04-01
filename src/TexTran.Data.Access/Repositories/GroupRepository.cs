//This code is auto generated. Changes to this file will be lost!
using System;
using System.Linq;
using TexTran.Data.Abstractions.Entities;
using TextTran.Data.Access.Context;

namespace TexTran.Data.Access.Repositories
{
	public class GroupRepository
	{
		private readonly TexTranContext _context;
		public GroupRepository(TexTranContext context)
		{
			_context = context;
		}

		public void Add(Group group)
		{
			_context.Groups.Add(group);
		}

		public void Delete(Group group)
		{
			_context.Groups.Remove(group);
		}

		public void Edit(Group group)
		{
			var editedEntity = _context.Groups.FirstOrDefault(e => e.Id == group.Id);
			editedEntity = group;
		}

		public Group GetById(Guid id)
		{
			return _context.Groups.FirstOrDefault(e => e.Id == id);
		}

		public void SaveChanges() => _context.SaveChanges();
	}
}

