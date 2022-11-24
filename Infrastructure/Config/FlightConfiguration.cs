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
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            //config many=>many
           // builder.HasMany(f => f.Passengers).WithMany(p=>p.Flights).UsingEntity(t=>t.ToTable("Resrvation"));
            //config one=>many
            //
            //DeleteBehavior delete avant tous dans la bd

            builder.HasOne(f => f.Plane).WithMany(pl => pl.Flights).HasForeignKey(f => f.PlaneFK).OnDelete(DeleteBehavior.Cascade);



        }
    }
}
