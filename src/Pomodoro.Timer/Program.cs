using System;
using Pomodoro.Domain.Entities;

namespace Pomodoro.Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            var pomodoro = new PomodoroPlan(Guid.NewGuid());
            pomodoro.Start();
        }
    }
}