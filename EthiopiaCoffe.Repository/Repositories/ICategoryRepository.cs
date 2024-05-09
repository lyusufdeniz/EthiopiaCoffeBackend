﻿using EthiopiaCoffe.Domain.Concrete.Entities;

namespace EthiopiaCoffe.Repository.Repositories
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        IQueryable<Category> CategoryWithProducts();
    }
}
