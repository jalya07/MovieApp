using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieApp.DAL.Models;

namespace MovieApp.DAL.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movies");
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Title)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(m => m.Description)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(m => m.ReleaseYear)
                .IsRequired();
            builder.Property(m => m.Duration)
                .IsRequired();
            builder.Property(m => m.Imdb)
                .IsRequired()
                .HasColumnType("decimail(18,2");
                
        }
    }
}

