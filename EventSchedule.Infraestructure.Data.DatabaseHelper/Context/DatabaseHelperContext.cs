using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventSchedule.Infraestructure.Data.DatabaseHelper.Context
{
    public class DatabaseHelperContext : DbContext
    {
        public DatabaseHelperContext(DbContextOptions<DatabaseHelperContext> options) : base(options) { }
    }
}
