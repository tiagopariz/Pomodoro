using System;
using Pomodoro.Core.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using Pomodoro.Domain.Enums;

namespace Pomodoro.Domain.Entities
{
    public class PomodoroPlan : Entity
    {
        public PomodoroPlan(Guid id)
                :base(id)
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
            Plan = pomodoro;
        }

        public Plan Plan { get; }

        public void Start()
        {
            foreach (var item in Plan.Periods)
            {
                item.Start();
            }
        }
    }
}