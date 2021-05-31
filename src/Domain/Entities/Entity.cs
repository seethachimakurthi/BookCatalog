﻿using BookCatalog.Domain.Abstractions;
using System;

namespace BookCatalog.Domain.Entities
{
    public class Entity : IEntity
    {
        public String id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}
