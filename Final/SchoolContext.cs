using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Final
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(): base()
        {

        }
        public DbSet<Student> Student { get; set; }
        
    }
}
