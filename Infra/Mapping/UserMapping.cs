using Sample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Sample.Infra.Mapping
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            this.ToTable("User");
            this.HasKey(x => x.Id);

            this.Property(x => x.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.CriationDate).HasColumnName("CriationDate");
            this.Property(x => x.Email).HasColumnName("Email").IsRequired().HasMaxLength(500);
            this.Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(500);
            this.Property(x => x.UserName).HasColumnName("UserName").IsRequired().HasMaxLength(50);

            this.Ignore(x => x.Password);
            this.Ignore(x => x.Perfil);


        }
    }
}