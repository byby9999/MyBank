namespace MyBank.Models
{
    public class Credit
    {
        public double Amount { get; set; }
        public int Months { get; set; }
        public double Interest { get; set; }

        public Person Applicant { get; set; }
    }
}
