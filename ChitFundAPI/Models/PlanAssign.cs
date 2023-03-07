using System.ComponentModel.DataAnnotations.Schema;

namespace ChitFundAPI.Models
{
    public class PlanAssign
    {
        public int Id { get; set; }

        [ForeignKey("Contact")]
        public int ContactId {get; set;}
        public virtual Contact Contact { get; set;}

        [ForeignKey("Plan")]
        public int PlanId { get; set;}
        public virtual Plan Plan { get; set;}
        public DateTime CreatedDate { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
