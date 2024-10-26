using Microsoft.EntityFrameworkCore;

namespace TCSA.WebAPI.FlightData.Data;

public class FlightsDbContext : DbContext
{
    public FlightsDbContext(DbContextOptions options) : base(options)
    {

    }
}