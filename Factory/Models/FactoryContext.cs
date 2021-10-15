using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public virtual Dbset<Machine> Machines { get; set; }
    public Dbset<Engineer> Engineers { get; set; }
    public FactoryContext(DbContextOptions options) : base(options){ }
    protected override void onConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}