using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace persistence.Data
{
    public class CuatroCapasContext : DbContext
    {
        public CuatroCapasContext(DbContextOptions options) : base(options)
        {
        }
    }
}