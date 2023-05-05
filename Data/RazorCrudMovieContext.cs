namespace RazorCrud.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

    public class RazorCrudMovieContext : DbContext
    {
        public RazorCrudMovieContext (DbContextOptions<RazorCrudMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorCrud.Models.Movie> Movie { get; set; } = default!;
    }
