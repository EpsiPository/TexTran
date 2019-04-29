
// This file is auto generated. Changes to this file will be lost!
using System;
using TexTran.Service.Abstractions.ViewModels;
using AutoMapper;
using TexTran.Data.Abstractions.Entities;

namespace TexTran.Service.Abstractions.Mapper.Profiles
{
	public class ModelToViewModelMapping: Profile
	{
		public ModelToViewModelMapping()
		{
			CreateMap<User, User>();
			CreateMap<Group, Group>();
		}
	}
}

