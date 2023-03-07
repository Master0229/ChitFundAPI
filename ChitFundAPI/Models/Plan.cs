using System.ComponentModel.DataAnnotations.Schema;

namespace ChitFundAPI.Models
{
    public class Plan
    {
        public int Id { get; set; }
        public string Invoice { get; set; }
        public string Name { get; set; }
        public float Amount { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

    }
}
