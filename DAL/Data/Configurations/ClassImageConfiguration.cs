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
    public class ClassImageConfiguration : IEntityTypeConfiguration<ClassImage>
    {
        public void Configure(EntityTypeBuilder<ClassImage> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ImageURL)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.HasOne(x => x.BusClass)
                .WithMany(x => x.ClassImages)
                .HasForeignKey(x => x.BusClassId)
                .IsRequired();

            builder.ToTable("ClassImages");


      
           
           
            
       

        }
    }
}
