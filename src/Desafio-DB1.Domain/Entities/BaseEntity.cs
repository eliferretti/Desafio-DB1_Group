﻿namespace Desafio_DB1.Domain.Entities
{
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }
    }
}
