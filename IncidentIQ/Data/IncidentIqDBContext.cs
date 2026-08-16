
using Microsoft.EntityFrameworkCore;

namespace IncidentIQ.Data;

public class IncidentIqDBContext : DbContext
{
    public IncidentIqDBContext(
        DbContextOptions<IncidentIqDBContext> options)
        : base(options)
    {
    }

    public DbSet<Incident> Incidents => Set<Incident>();
}