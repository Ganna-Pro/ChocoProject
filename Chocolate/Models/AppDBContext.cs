﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Chocolate.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {

        }

        public DBSet<Flavours> Flavours { get; set; }
        
    }
}
