﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NatuArgWEB.Data.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(string url, int Id);
        Task<List<T>> GetAllAsync(string url);
        Task<bool> CreateAsync(string url, T objToCreate);
        Task<bool> UpdateAsync(string url, T objToUpdate);
        Task<bool> DeleteAsync(string url, int Id);
    }
}
