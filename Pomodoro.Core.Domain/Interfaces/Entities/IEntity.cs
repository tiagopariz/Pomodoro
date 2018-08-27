using System;

namespace Pomodoro.Core.Domain.Interfaces.Entities
{
    public interface IEntity
    {
        Guid Id { get; }
    }
}