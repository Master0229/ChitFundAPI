using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChitFundAPI.Models
{
    public class TransType
    {
        public int Id { get; set; }
        public string Description { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }  
        public virtual Company Company { get; set; }
        

    }
}
