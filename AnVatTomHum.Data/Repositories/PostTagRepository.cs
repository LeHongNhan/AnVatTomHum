using AnVatTomHum.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnVatTomHum.Data.Repositories
{
    public interface IRepository
    {

    }
    public class PostTagRepository: RepositoryBase<PostTagRepository>
    {
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
