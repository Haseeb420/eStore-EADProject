using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace EStore.Shared
{
    class MyShopContext:DbContext
    {
        DbSet<Product> Products;
        protected override void OnConfiguring(DbContextOptionsBuilder options)
          => options.UseSqlServer(@"Data Source=C:\blogging.db");
    }
}
