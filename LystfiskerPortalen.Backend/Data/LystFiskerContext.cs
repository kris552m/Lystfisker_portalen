using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LystfiskerPortalen.Backend.Data
{
    public class LystFiskerContext : DbContext
    {
        //Dbsets
        public LystFiskerContext(DbContextOptions<LystFiskerContext> options)
            : base(options)
        {
        }

    }
}