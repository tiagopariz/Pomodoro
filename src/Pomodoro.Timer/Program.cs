using System;
using Pomodoro.Domain.Entities;

namespace Pomodoro.Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            var plan = new Plan(Guid.NewGuid());
            plan.SetPomodoro();
            plan.Start();
        }
    }
}