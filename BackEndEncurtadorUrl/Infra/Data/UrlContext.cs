using Microsoft.EntityFrameworkCore;
using Domain.Entidades;

namespace Infra.Data;

public class UrlContext : DbContext
{
    public UrlContext (DbContextOptions<UrlContext> options) : base(options)
    {
    }

    public DbSet<UrlContext> TabelaUrlContext {get; set;}
}