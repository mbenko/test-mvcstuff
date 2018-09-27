
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace MVCRockers.Models
{
    public interface ITestDbContext
    {
        IDbSet<Concert> Concerts { get; set; }
        int SaveChanges();
        int Entry(Concert concert);
    }

    public class TestDbContext : IdentityDbContext<ApplicationUser>, ITestDbContext
    {
        public TestDbContext()
            : base("MVCRockerDB", throwIfV1Schema: false)
        {
        }

        public static ITestDbContext Create()
        {
            return new TestDbContext();
        }

        public new int Entry(Concert concert)
        {
            throw new System.NotImplementedException();
        }

        public IDbSet<MVCRockers.Models.Concert> Concerts { get; set; }
    }

    public class FakeTestDbContext : ITestDbContext
    {
        public IDbSet<Concert> Concerts { get; set; }

        public int SaveChanges()
        {
            return 0;
        }
        public int Entry(Concert concert)
        {
            return 0;
        }

    }
}