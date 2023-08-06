﻿using OnionArchitectureApp.Domain.Common;
using OnionArchitectureApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.İnterfaces.Repository
{
	public interface IGenericRepositoryAsync<T> where T : BaseEntity
	{
		Task<List<T>> GetAllAsync();
		Task<T> GetByIdAsync(Guid id);
		Task<T> AddAsync(T entity);
	}
}
