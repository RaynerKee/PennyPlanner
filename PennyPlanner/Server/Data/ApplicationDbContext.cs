using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PennyPlanner.Server.Models;
using PennyPlanner.Shared.Domain;

namespace PennyPlanner.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Savings> Savings { get; set; }
        public DbSet<Article> Articles { get; set; }


    }
}