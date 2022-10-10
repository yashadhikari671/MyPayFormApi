using Microsoft.EntityFrameworkCore;
using MyPayFormApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPayFormApi.Data
{
    public class AppDbcontext :DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {

        }
        public virtual DbSet<Form> Applicants { get; set; }
    }
}
