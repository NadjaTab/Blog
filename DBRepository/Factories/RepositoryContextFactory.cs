﻿using System;
using System.Collections.Generic;
using DBRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Text;


namespace DBRepository
{
    public class RepositoryContextFactory : IRepositoryContextFactory
    {
        public RepositoryContext CreateDbContext(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RepositoryContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new RepositoryContext(optionsBuilder.Options);
        }

        
    }
}
