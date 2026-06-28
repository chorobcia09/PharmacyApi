using Microsoft.EntityFrameworkCore;

namespace Pharmacy.Database;

public class PharmacyDbContext(DbContextOptions<PharmacyDbContext> options) : DbContext(options)
{
    public DbSet<Medication> Medication => Set<Medication>();
}
