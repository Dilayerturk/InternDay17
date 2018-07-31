using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
    class PersonDbContext : DbContext
    {
        public PersonDbContext(string connectionName) : base(connectionName)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
