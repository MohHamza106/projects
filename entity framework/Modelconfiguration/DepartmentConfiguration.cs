using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using entity_framework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace entity_framework.Modelconfiguration
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("department");
            builder.HasKey(d=>d.depId);
            builder.Property(d=>d.Name).HasColumnName("deptNAme")
                .HasColumnType("varchar")
                .HasMaxLength(10)
                .IsRequired( false);
           
            builder.Property(d => d.Description)
                .HasColumnName("Description")
                .HasMaxLength(30)
                .HasDefaultValue("alex");
            //builder.HasData(new Department (){ depId=30, Name="mohamed"});

            builder.Property(d => d.Type)
                .HasColumnType("int ");
            //one to many
            builder .HasMany(d => d.employees)
                     .WithOne(e => e.EMployeeDepatment)
                        .HasForeignKey(e => e.dep_id);
        }
    }
}
