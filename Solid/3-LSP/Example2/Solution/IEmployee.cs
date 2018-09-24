namespace Solid._3_LSP.Example2.Solution
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }

        void CalcularePerHourRate(int rank);
    }
}