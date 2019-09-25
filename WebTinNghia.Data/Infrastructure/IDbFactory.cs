using System;

namespace WebTinNghia.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        WebTinNghiaDbContext Init();
    }
}
