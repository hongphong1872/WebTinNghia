﻿using WebTinNghia.Data.Infrastructure;
using WebTinNghia.Model.Models;
namespace WebTinNghia.Data.Repositories
{
    public interface ISlideRepository : IRepository<Slide>
    {
    }

    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
