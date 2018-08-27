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
                      int size,
                      PeriodType type,
                      Period nextPeriod)
                :base(id)
        {
            Title = title;
            Order = order;
            Size = size;
            Type = type;
            NextPeriod = nextPeriod;
        }

        public string Title { get; }
        public int Order { get; }
        public int Size { get; }
        public PeriodType Type { get; }
        public Period NextPeriod { get; }
        public int Current => current;

        public void Start()
        {
            for (var i = 0; i < Size; i++)
            {
                current = i;
                Thread.Sleep(1000 * 60);
                Console.Write(".");
            }
        }
    }
}