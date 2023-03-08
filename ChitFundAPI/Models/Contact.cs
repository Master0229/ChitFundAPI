using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChitFundAPI.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }    
        public string? City { get; set; }
        public string? Email { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }

        [ForeignKey("Parentcontact")]
        public int ParentcontactId { get; set; }
        public virtual Parentcontact?  Parentcontact { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public virtual Company? Company { get; set; }


    }
}
