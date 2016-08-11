using PolicyHost.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyRepository.DatabaseConfiguration
{
    class PolicyDetailsMap : EntityTypeConfiguration<PolicyDetails>
    {
        public PolicyDetailsMap()
        {
            HasKey(p => p.Id);

            Property(p => p.Id)
                .HasColumnName("policy_general_id")
                .HasColumnType("int");

            Property(p => p.StorageDate)
                .HasColumnName("storage_date")
                .HasColumnType("DateTime")
                .IsOptional();

            Property(p => p.RelationId)
                .HasColumnName("relation_id")
                .HasColumnType("int")
                .IsOptional();

            Property(p => p.PolicyNumber)
                .HasColumnName("policy_number")
                .HasColumnType("int");

            Property(p => p.ProductId)
                .HasColumnName("product_id")
                .HasColumnType("int");

            Property(p => p.StartDate)
                .HasColumnName("initial_startdate")
                .HasColumnType("DateTime")
                .IsRequired();

            Property(p => p.ExpirationDate)
                .HasColumnName("expiration_date")
                .HasColumnType("int")
                .IsRequired();

            Property(p => p.BrandId)
                .HasColumnName("brand_id")
                .HasColumnType("int");

            Property(p => p.IsPolicySourceMigration)
                .HasColumnName("IsPolicySourceMigration")
                .HasColumnType("bit");


    }
    }
}
