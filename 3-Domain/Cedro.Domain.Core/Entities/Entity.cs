using System;
using FluentValidation;
using FluentValidation.Results;

namespace Cedro.Domain.Core.Entities
{
    public abstract class Entity<T> : AbstractValidator<T> where T  : Entity<T>
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public ValidationResult ValidationResult { get; protected set; }
        public abstract bool IsValidated();
    }
}