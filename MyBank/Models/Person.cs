namespace MyBank.Models
{
    public class Person
    {
        public string FullName { get; set; }
        public Dictionary<string, int> JobHistory { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
