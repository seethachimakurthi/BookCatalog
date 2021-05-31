﻿using System;

namespace BookCatalog.Domain.Abstractions
{
    public interface IEntity
    {
        String id { get; set; }
        DateTime CreatedDateTime { get; set; }
        DateTime UpdatedDateTime { get; set; }
    }
}
