using System;
using Pomodoro.Core.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using Pomodoro.Domain.Enums;

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
            var period = new Period(Guid.NewGuid(), title, order, minutes, PeriodType.Interval, null);
            _periods.Add(period);
        }
    }
}