using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movie_Web_App.Models;

namespace Movie_Web_App.Data
{
    public class Movie_Web_AppContext : DbContext
    {
        public Movie_Web_AppContext (DbContextOptions<Movie_Web_AppContext> options)
            : base(options)
        {
        }

        public DbSet<Movie_Web_App.Models.Movie> Movie { get; set; } = default!;
    }
}
