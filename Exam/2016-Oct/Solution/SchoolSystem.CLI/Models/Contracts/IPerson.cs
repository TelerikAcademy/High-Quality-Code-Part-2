namespace SchoolSystem.Cli.Models.Contracts
{
    /// <summary>
    /// Represents a Person with the basic attributes FirstName and LastName
    /// </summary>
    public interface IPerson
    {
        string FirstName { get; set; }

        string LastName { get; set; }
    }
}
