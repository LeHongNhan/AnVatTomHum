using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AnVatTomHum.Data.Infrastructure
{
    public class DbFactory : Dispoable, IDbFactory
    {
        AnVatTomHumDbContext dbContext;
        public AnVatTomHumDbContext Init()
        {
            return dbContext??(dbContext=new AnVatTomHumDbContext());
        }
        protected override void Dispose(bool disposing)
        {
            if (dbContext!=null)
            {
                dbContext.Dispose();
            }
        }
    }
}
