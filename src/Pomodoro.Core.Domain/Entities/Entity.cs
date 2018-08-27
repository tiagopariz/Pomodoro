using System;
using Pomodoro.Core.Domain.Interfaces.Entities;

namespace Pomodoro.Core.Domain.Entities
{   
    public abstract class Entity : IEntity
    {
        public Entity(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}