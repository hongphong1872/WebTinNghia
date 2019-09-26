using WebTinNghia.Data.Infrastructure;
using WebTinNghia.Model.Models;

namespace WebTinNghia.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>
    {
    }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
