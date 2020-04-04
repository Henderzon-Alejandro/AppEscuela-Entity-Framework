using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscuelaEF.Context
{
    public class EscuelaDbContext : DbContext
    {
        public EscuelaDbContext() : base("name=AppEscuelaBDAzure")
        {
        }
    }
}
