using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class EshopContext : DbContext
    {
        public EshopContext(DbContextOptions<EshopContext> options)
        : base(options)
        {
        }
        public DbSet<Taikhoan> Taikhoans { get; set; }
        public DbSet<Thanhvien> Thanhviens { get; set; }
        public DbSet<Tintuc> Tintucs { get; set; }
    }
}
