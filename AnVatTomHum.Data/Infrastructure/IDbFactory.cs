using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnVatTomHum.Data.Infrastructure
{
    public interface IDbFactory:IDisposable
    {
        AnVatTomHumDbContext Init();
    }
}
