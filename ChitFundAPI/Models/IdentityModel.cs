using Microsoft.EntityFrameworkCore;

namespace ChitFundAPI.Models
{
    public class IdentityModel : DbContext
    {
        public IdentityModel(DbContextOptions<IdentityModel> options) : base(options)
        {


        }
    }
}
