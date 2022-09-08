using MyBank.Models;

namespace MyBankTests
{
    public class CreditTests
    {
        [Fact]
        public void Apply_WhenApplicantMinor_ShouldReject()
        {
            var applicant = new Person { BirthDate = new DateTime(2010, 12, 12) };
            var calculator = new Calculator();

            var credit = new Credit { Amount = 3200, Applicant = applicant, Months = 20 };

            var result = calculator.Apply(credit);

            Assert.Equal(CreditStatus.Rejected, result);
        }

        [Fact]
        public void Apply_JobHistoryWithMinimum2Jobs_ShouldAccept()
        {
            var applicant = new Person
            {
                BirthDate = new DateTime(2000, 12, 12),
                JobHistory = new Dictionary<string, int> { { "Comp", 2 }, { "Frfee", 4 }, { "SUperX", 3 } }
            };
            var calculator = new Calculator();

            var credit = new Credit { Amount = 3200, Applicant = applicant, Months = 20 };

            var result = calculator.Apply(credit);

            Assert.Equal(CreditStatus.Accepted, result);
        }
    }
}