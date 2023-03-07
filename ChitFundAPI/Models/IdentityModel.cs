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
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Plandetail> Plandetails { get; set; }
        public DbSet<PlanAssign> PlanAssigns { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<SubTrans> SubTrans { get; set; }
    }
}
