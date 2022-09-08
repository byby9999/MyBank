namespace MyBank.Models
{
    public class Calculator
    {
        public CreditStatus Apply(Credit credit, int years = 5)
        {
            var age = DateTime.Now.Year - credit.Applicant.BirthDate.Year;
            if (age < 18)
            return CreditStatus.Rejected;

            if (credit.Amount > 50000)
            {
                if (credit.Applicant.JobHistory?.Count() < 2) 
                {
                    return CreditStatus.ReferredToHuman;
                }
            }

            if (credit.Amount > 100000 &&
                (credit.Applicant.JobHistory == null || credit.Applicant.JobHistory.Count() == 0))
                return CreditStatus.Rejected;

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
