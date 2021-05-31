﻿using BookCatalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookCatalog.MicroService.Infra.Persistence.EfCore.Mappings
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(m => m.id);


            builder.Property(c => c.title)
                .HasMaxLength(100)
                .IsRequired()
                .HasField("Title"); ;

            builder.Property(c => c.author)
                .HasMaxLength(100)
                .IsRequired()
                .HasField("Author"); ;
        }
    }
}
