﻿using Api.Data.Context.Contract;
using Api.Data.Context.Model;
using Api.Data.Repository.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Data.Repository
{
    public class RepositoryComments : GenericRepository<Comment>, IRepositoryComments
    {
        public RepositoryComments(IDBContext _idbcontext) : base(_idbcontext)
        {
        }
        private readonly DbSet<Comment> _table;

    }
}
