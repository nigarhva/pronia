using Microsoft.EntityFrameworkCore;
using Proina.Domin.Entities;

namespace Pronia.DataAccess.Contexts;

public class ProniaDbContext: DbContext
{
    public ProniaDbContext(DbContextOptions options): base(options)
    {

    }
    public DbSet<Slider> Sliders { get; set; }
}
