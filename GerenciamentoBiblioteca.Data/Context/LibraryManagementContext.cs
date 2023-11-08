using GerenciamentoBiblioteca.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoBiblioteca.Data.Context
{
    public class LibraryManagementContext : DbContext
    {
        public LibraryManagementContext(DbContextOptions<LibraryManagementContext> options) :base(options)
        { }

        #region Tables
        public DbSet<Author> Author { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Loan> Loan { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Status> Status { get; set; }
        #endregion
    }
}