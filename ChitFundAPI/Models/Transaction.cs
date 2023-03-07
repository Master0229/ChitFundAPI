using System.ComponentModel.DataAnnotations.Schema;

namespace ChitFundAPI.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public float Amount { get; set; }

        [ForeignKey("Plan")]
        public int PlanId { get; set; }
        public virtual Plan Plan { get; set; }

        [ForeignKey("Plandetail")]
        public int? PlanDetailsId {get; set; }
        public virtual Plandetail Plandetail { get; set; }

        [ForeignKey("TransType")]
        public int TransTypeId { get; set; }
        public virtual TransType TransType { get; set; }

        [ForeignKey("Contact")]
        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        [ForeignKey("User")]
        public int ReferedBy { get; set; }
        public virtual User User { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsPaid { get; set; }
    }
}
