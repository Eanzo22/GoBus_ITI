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
    public class BusClassConfiguration : IEntityTypeConfiguration<BusClass>
    {
        public void Configure(EntityTypeBuilder<BusClass> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
               .HasColumnType("varchar(max)")
               .IsRequired();



            builder.ToTable("BusClasses");



           
             

       

        }
    }
}
