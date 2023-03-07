using System.ComponentModel.DataAnnotations.Schema;

namespace ChitFundAPI.Models
{
    public class SubTrans
    {
        public int Id { get; set; }
        
        [ForeignKey("Transaction")]
        public int TransactionId { get; set; }
        public virtual Transaction Transaction { get; set; }

        public float Amount { get; set; }
        public DateTime TransDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }

        [ForeignKey("PaymentType")]
        public int PaymentTypeId { get; set; }
        public virtual PaymentType PaymentType { get; set; }

        [ForeignKey("Contact")]
        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }

        [ForeignKey("User")]
        public int ReferedBy { get; set; }
        public virtual User User { get; set; }



    }
}
