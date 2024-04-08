using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W20240408.AccesoADatos
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            const string Cnn = "Server=DESKTOP-U3NM1TE;Initial Catalog=W20240408DB;Integrated Security=True";
            optionsBuilder.UseSqlServer(Cnn);

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
