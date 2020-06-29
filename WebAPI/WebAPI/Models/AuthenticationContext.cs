using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class AuthenticationContext : IdentityDbContext
    {
        public AuthenticationContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Lst_LaiXe> Lst_LaiXe { get; set; }
        public DbSet<Lst_Xe> Lst_Xe { get; set; }
        public DbSet<Lst_KiThuatVien> Lst_KiThuatVien { get; set; }
    }
}
