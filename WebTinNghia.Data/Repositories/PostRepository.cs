using WebTinNghia.Data.Infrastructure;
using WebTinNghia.Model.Models;

namespace WebTinNghia.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
