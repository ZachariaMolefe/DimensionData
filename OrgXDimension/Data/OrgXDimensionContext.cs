﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OrgXDimension.Models
{
    public class OrgXDimensionContext : DbContext
    {
        public OrgXDimensionContext (DbContextOptions<OrgXDimensionContext> options)
            : base(options)
        {
        }

        public DbSet<OrgXDimension.Models.ApplicatonItems> ApplicatonItems { get; set; }
    }
}