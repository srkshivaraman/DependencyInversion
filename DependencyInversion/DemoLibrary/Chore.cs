using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Chore
    {
        public string ChoreName { get; set; }
        public Person Owner { get; set; }

        public double HoursWorked { get; private set; }

        public bool IsComplete { get; private set; }

        public void CompleteChore()
        {
            IsComplete = true;
            Logger logger = new Logger();
            logger.Log($"Completed {ChoreName}");

            Emailer emailer = new Emailer();
            emailer.SendEmail(Owner, $"The chore {ChoreName} is complete.");
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            Logger logger = new Logger();
            logger.Log($"Performed work on {ChoreName}");
        }

    
    }
}
