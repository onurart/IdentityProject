using IdentityEntities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace IdentityDataAccesLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        //}
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public Context()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("SqlConnection"));
        }
        public DbSet<CustomerAccount> CustomerAccount { get; set; }
        public DbSet<CustomerAccountProcess> AccountProcesses { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
            builder.Entity<CustomerAccountProcess>()
               .HasOne(x=>x.SenderCustomer)
               .WithMany(x=>x.CustomerReceivere)
               .HasForeignKey(x=>x.SenderID)
               .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<CustomerAccountProcess>()
                .HasOne(x => x.ReceiverCustomer)
                .WithMany(x => x.CustomerReceivere)
                .HasForeignKey(x => x.ReceiverID)
                .OnDelete(DeleteBehavior.ClientSetNull);
            base.OnModelCreating(builder);
		}
	}
}
