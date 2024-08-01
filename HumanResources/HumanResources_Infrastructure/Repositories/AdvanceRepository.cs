﻿using HumanResources_Domain.Entities;
using HumanResources_Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources_Infrastructure.Repositories
{
    public class AdvanceRepository : BaseRepository<Advance>, IAdvanceRepository
    {
        public AdvanceRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
