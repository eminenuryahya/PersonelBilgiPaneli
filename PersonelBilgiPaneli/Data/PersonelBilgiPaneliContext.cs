using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersonelBilgiPaneli.Models;

namespace PersonelBilgiPaneli.Data
{
    public class PersonelBilgiPaneliContext : DbContext
    {
        public PersonelBilgiPaneliContext (DbContextOptions<PersonelBilgiPaneliContext> options)
            : base(options)
        {
        }

        public DbSet<PersonelBilgiPaneli.Models.Personel> Personel { get; set; } = default!;
    }
}
