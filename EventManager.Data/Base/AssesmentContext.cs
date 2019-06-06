using EventManager.Entity;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Data.Base
{
    public class AssesmentContext : DbContext
    {

        public AssesmentContext() : base("AssesmentDBContext")
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 120;
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Event> Events { get; set; }


    }
}
