﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DBContextOptions options) : base(options)
        {

        }

        public DBSet<Activity> Activities { get; set; }

    }
}
