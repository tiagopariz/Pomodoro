using System;
using Pomodoro.Core.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using Pomodoro.Domain.Enums;
using Pomodoro.Domain.ValueObjects;

namespace Pomodoro.Domain.Entities
{
    public class Plan : Entity
    {
        private IList<Period> _periods;

        public Plan(Guid id)
            : base(id)
        {
            _periods = new List<Period>();
        }

        public IReadOnlyCollection<Period> Periods => _periods.ToArray();

        public void AddPeriod(int minutes, string title = "")
        {
            var order = _periods?.Count() ?? 0;
            var period = new Period(Guid.NewGuid(), title, order, minutes, PeriodType.Period, null);
            _periods.Add(period);
        }

        public void AddInterval(int minutes, string title = "")
        {
            var order = _periods?.Count() ?? 0;
            var period = new Period(Guid.NewGuid(), 
                                    title,
                                    order,
                                    minutes,
                                    PeriodType.Interval,
                                    null);
            _periods.Add(period);
        }

        public void SetPomodoro()
        {
            _periods = new List<Period>();
            AddPeriod(25, "Pomodoro 1");
            AddInterval(5, "Interval 1");
            AddPeriod(25, "Pomodoro 2");
            AddInterval(5, "Interval 2");
            AddPeriod(25, "Pomodoro 3");
            AddInterval(5, "Interval 3");
            AddPeriod(25, "Pomodoro 4");
            AddInterval(30, "Interval 4");
        }

        public void Start(int repeat = 1)
        {
            for (var i = 1; i <= repeat; i++)
            {
                foreach (var item in Periods)
                {
                    item.Start();
                    var soundBeep = new Sound("");
                    soundBeep.Play();
                }                
            }
        }
    }
}