using DemoLibrary;

public class Program
{
    private static void Main(string[] args)
    {
        Person owner = new Person();
        owner.FirstName = "Peter";
        owner.LastName = "Parker";
        owner.EmailAddress = "ceo@parkerindustries.com";
        owner.PhoneNumber = "9876543210";

        Chore chore = new Chore();
        chore.ChoreName = "Clean my room";
        chore.Owner= owner;

        chore.PerformedWork(3);
        chore.PerformedWork(1.5);
        chore.CompleteChore();

        Console.ReadLine();
    }
}