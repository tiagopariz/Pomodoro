using System;
using Pomodoro.Domain.Entities;

namespace Pomodoro.Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            var pomodoro = new Plan(Guid.NewGuid());
            pomodoro.AddPeriod(25, "Pomodoro 1");
            pomodoro.AddInterval(5, "Interval 1");
            pomodoro.AddPeriod(25, "Pomodoro 2");
            pomodoro.AddInterval(5, "Interval 2");
            pomodoro.AddPeriod(25, "Pomodoro 3");
            pomodoro.AddInterval(5, "Interval 3");
            pomodoro.AddPeriod(25, "Pomodoro 4");
            pomodoro.AddInterval(30, "Interval 4");

            foreach (var item in pomodoro.Periods)
            {
                //Console.WriteLine(item.Title);
                item.Start();
                //Console.WriteLine();
            }
        }
    }
}