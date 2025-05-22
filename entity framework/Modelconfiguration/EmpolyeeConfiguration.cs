using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using entity_framework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace entity_framework.Modelconfiguration
{
    internal class EmpolyeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(e => e.Id);
            builder.Property<string>("Name");
            builder.Property(e => e.Address)
                .HasColumnName("employeeAddress").
                HasColumnType("varchar").
                HasDefaultValue("monsoure")
                .HasMaxLength(20)
                .IsRequired(false);
            builder.Property(e => e.Address).HasColumnName("Employeeadress")
                .HasMaxLength(20);
            //relationship of one to one  all mandatory
            builder.OwnsOne(e => e.empaddress, Address=>Address.WithOwner());
           
            //one to many
                builder.HasOne(e => e.EMployeeDepatment)
                         .WithMany(d => d.employees)
                          .HasForeignKey(e => e.dep_id)
                          .IsRequired()
                           .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
