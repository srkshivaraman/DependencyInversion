using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Chore : IChore
    {
        private readonly ILogger logger;
        private readonly IMessageSender messageSender;

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }

        public double HoursWorked { get; private set; }

        public bool IsComplete { get; private set; }

        public Chore(ILogger logger,IMessageSender messageSender)
        {
            this.logger = logger;
            this.messageSender = messageSender;
        }

        public void CompleteChore()
        {
            IsComplete = true;            
            logger.Log($"Completed {ChoreName}");
           
            messageSender.SendMessage(Owner, $"The chore {ChoreName} is complete.");
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            logger.Log($"Performed work on {ChoreName}");
        }


    }
}
