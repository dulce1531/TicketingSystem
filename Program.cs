
namespace A1TicketingSystem;

public class Class1
{
    static void Main(string[] args)
    {
        //TicketID,Summary,Status,Priority,Submitter,Assigned,Watching
        //1,This is a bug ticket,Open,High,Drew Kjell,Jane Doe,Drew Kjell|John Smith|Bill Jones
        Console.WriteLine("Ticket ID:");
        int ticketID = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Summary:");
        string summary = Console.ReadLine();

        Console.WriteLine("Status:");
        var status = Console.ReadLine();

        Console.WriteLine("Priority:");
        var priority = Console.ReadLine();

        Console.WriteLine("Submitter:");
        string submitter = Console.ReadLine();
        
        Console.WriteLine("Assigned:");
        string assigned = Console.ReadLine();

        string[] watching = new string[22];
        int i;
        for (i = 0; i < 22; i++)
        {
            Console.WriteLine("Enter name (Y/N)?");
            string resp = Console.ReadLine().ToUpper();

            if (resp != "Y")
            {
                break;
            }

            Console.WriteLine("Enter name:");

            watching[i] = Console.ReadLine();
        }
        
        string output = string.Concat(ticketID, summary, status, priority, submitter, assigned, watching[i]);
        Console.Clear();
    }
}
