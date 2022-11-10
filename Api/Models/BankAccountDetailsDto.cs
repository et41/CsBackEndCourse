namespace Api.Models
{
    public class BankAccountDetailsDto : BillingDetail
    {
        public string BankName { get; set; }
        public string Swift { get; set; }
    }
}
