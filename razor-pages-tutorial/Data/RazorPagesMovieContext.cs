using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Data
{
  public class RazorPagesMovieContext : DbContext
  {
    public RazorPagesMovieContext (
      DbContextOptions<RazorPagesMovieContext> options) : base(options) {

      }

      public DbSet<RazorPagesMovie.Model.Movie> Movie { get; set; }
    )
  }
}