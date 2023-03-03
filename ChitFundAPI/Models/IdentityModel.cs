using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ChitFundAPI.Models
{
    public class IdentityModel : DbContext
    {
        public IdentityModel(DbContextOptions<IdentityModel> options) : base(options)
        {


        }
        public DbSet<Parentcontact> Parentcontacts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<TransType> TransTypes { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
    }
}
