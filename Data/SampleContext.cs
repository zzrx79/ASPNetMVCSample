using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleMVC.Models;

namespace SampleMVC.Data
{
    public class SampleContext : DbContext
    {
        public SampleContext (DbContextOptions<SampleContext> options)
            : base(options)
        {
        }

        public DbSet<SampleMVC.Models.SampleModel> SampleModel { get; set; }
    }
}
