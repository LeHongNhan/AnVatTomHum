﻿using AnVatTomHum.Data.Infrastructure;
using AnVatTomHum.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnVatTomHum.Data.Repositories
{
    public interface ITagRepository
    {

    }
    public class TagRepository : RepositoryBase<Post>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
