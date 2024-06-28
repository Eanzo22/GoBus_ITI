using DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Configurations
{
    public class ReportConfigration : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FullName)
             .HasColumnType("varchar(max)")
             .IsRequired();

            builder.Property(x => x.Email)
            .HasColumnType("varchar(max)")
            .IsRequired();

            builder.Property(x => x.PhoneNumber)
            .HasColumnType("varchar(max)")
            .IsRequired();

            builder.Property(x => x.ReservationNumber)
               .HasColumnType("int")
               .IsRequired();

            builder.Property(x => x.MessageTitle)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.Property(x => x.MessageContent)
               .HasColumnType("varchar(max)")
               .IsRequired();

            builder.ToTable("Reports");


            builder.HasData(new List<Report>
            {

                #region Reports
                new Report
                {
                     Id = 1,
                     FullName = "John Doe",
                     Email = "john.doe@example.com",
                     PhoneNumber = "123-456-7890",
                     ReservationNumber = 1001,
                     MessageTitle = "Inquiry about Booking",
                     MessageContent = "I would like to know if I can change my reservation dates."

                },

                new Report
                {
                      Id = 2,
                      FullName = "Jane Smith",
                      Email = "jane.smith@example.com",
                      PhoneNumber = "098-765-4321",
                      ReservationNumber = 1002,
                      MessageTitle = "Issue with Payment",
                      MessageContent = "I encountered an issue while making a payment. Please assist."
                },

                new Report
                {
                     Id = 3,
                     FullName = "Alice Johnson",
                     Email = "alice.johnson@example.com",
                     PhoneNumber = "555-123-4567",
                     ReservationNumber = 1003,
                     MessageTitle = "Cancellation Request",
                     MessageContent = "I would like to cancel my reservation. What is the procedure?"
                },

                new Report
                {
                    Id = 4,
                    FullName = "Bob Brown",
                    Email = "bob.brown@example.com",
                    PhoneNumber = "444-321-0987",
                    ReservationNumber = 1004,
                    MessageTitle = "Feedback",
                    MessageContent = "The trip was great, but the bus was a bit late. Overall, good service."
                },

                new Report
                {
                    Id = 5,
                    FullName = "Charlie Davis",
                    Email = "charlie.davis@example.com",
                    PhoneNumber = "333-456-7890",
                    ReservationNumber = 1005,
                    MessageTitle = "Lost and Found",
                    MessageContent = "I left my bag on the bus. How can I retrieve it?"
                }
                
                #endregion

            }) ;
        }
    }
}
