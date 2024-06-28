using DAL.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Configurations
{
    public class BusConfiguration : IEntityTypeConfiguration<Bus>
    {
        public void Configure(EntityTypeBuilder<Bus> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Number)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.Capacity)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.Model)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.Property(x => x.Year)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.Property(x => x.CurrentBranch)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.Property(x => x.Available)
               .HasColumnType("bit")
               .IsRequired();

            builder.HasOne(x => x.BusClass)
                .WithMany(x => x.Buses)
                .HasForeignKey(x => x.BusClassId)
                .IsRequired();

            builder.HasOne(x => x.Driver)
                .WithMany(x => x.Buses)
                .HasForeignKey(x => x.DriverId)
                .IsRequired();

            builder.HasMany(x => x.Trips)
                .WithOne(x => x.Bus)
                .HasForeignKey(x => x.BusId)
                .IsRequired();

            builder.ToTable("Buses");

 
        }
    
    }
}
