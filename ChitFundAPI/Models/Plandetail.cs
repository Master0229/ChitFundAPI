using System.ComponentModel.DataAnnotations.Schema;

namespace ChitFundAPI.Models
{
    public class Plandetail
    {
        public int Id { get; set; }

        [ForeignKey("Plan")]
        public int PlanId { get; set; }
        public virtual Plan Plan { get; set; }
        public int Due { get; set; }
        public float SettleAmount { get; set; }
        public float ActualAmount { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

    }
}
