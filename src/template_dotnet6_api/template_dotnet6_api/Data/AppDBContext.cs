using Microsoft.EntityFrameworkCore;

namespace template_dotnet6_api.Data
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext() { }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
    }
}
