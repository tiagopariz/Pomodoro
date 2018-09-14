using System;
using System.Threading;
using Pomodoro.Core.Domain.Entities;
using Pomodoro.Domain.Enums;

namespace Pomodoro.Domain.Entities
{
    public class Period : Entity
    {
        private int current;

        public Period(Guid id,
                      string title,
                      int order,
                      int recap,
                      int minutes,
                      int review,
                      PeriodType type,
                      Period nextPeriod)
                : base(id)
        {
            Title = title;
            Order = order;
            Recap = recap;
            Minutes = minutes;
            Review = review;
            Type = type;
            NextPeriod = nextPeriod;
        }

        public string Title { get; }
        public int Order { get; }
        public int Recap { get; }
        public int Minutes { get; }
        public int Review { get; }
        public PeriodType Type { get; }
        public Period NextPeriod { get; }
        public int Current => current;

        public void Start()
        {
            for (var i = 0; i < Minutes; i++)
            {
                if (Type == PeriodType.Period)
                    Console.BackgroundColor = ConsoleColor.Red;
                else
                    Console.BackgroundColor = ConsoleColor.Green;
                
                current = i;
                Thread.Sleep(1000 * 60);
                Console.Write(".");
                Console.ResetColor();
            }
            Console.Write("|");
        }
    }
}