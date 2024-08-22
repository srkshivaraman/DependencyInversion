using DemoLibrary;
using DependencyInversion;

public class Program
{
    private static void Main(string[] args)
    {
        IPerson owner = Factory.CreatePerson();
        owner.FirstName = "Peter";
        owner.LastName = "Parker";
        owner.EmailAddress = "ceo@parkerindustries.com";
        owner.PhoneNumber = "9876543210";

        IChore chore = Factory.CreateChore();
        chore.ChoreName = "Clean my room";
        chore.Owner= owner;

        chore.PerformedWork(3);
        chore.PerformedWork(1.5);
        chore.CompleteChore();

        Console.ReadLine();
    }
}