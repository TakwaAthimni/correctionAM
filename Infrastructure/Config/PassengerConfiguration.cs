using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Config
{
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            //Configurer le type détenu
            builder.OwnsOne(p => p.FullName          
            ,       full => { full.Property(f => f.FirstName).HasColumnName("PassFirstName");
                    full.Property(f => f.LastName).HasColumnName("PassLastName").IsRequired();
                });
            //Configurer l'approche d'héritage TPH
            //builder.HasDiscriminator<int>("IsTraveller")
            //    .HasValue<Passenger>(0)
            //    .HasValue<Staff>(2)
            //    .HasValue<Traveller>(1);


        }
    }
}
