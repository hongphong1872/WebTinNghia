namespace WebTinNghia.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private WebTinNghiaDbContext dbContext;

        public WebTinNghiaDbContext Init()
        {
            return dbContext ?? (dbContext = new WebTinNghiaDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
