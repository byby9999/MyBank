namespace MyBank.Models
{
    public class Calculator
    {
        public CreditStatus Apply(Credit credit)
        {
            var age = DateTime.Now.Year - credit.Applicant.BirthDate.Year;
            if (age < 18)
                return CreditStatus.Rejected;

            if (credit.Amount > 50000 && credit.Applicant.JobHistory?.Count() < 2)
            {
                return CreditStatus.ReferredToHuman;
            }

            return CreditStatus.Accepted;
        }
    }

    public enum CreditStatus
    {
        Accepted,
        Rejected,
        ReferredToHuman
    }
}
