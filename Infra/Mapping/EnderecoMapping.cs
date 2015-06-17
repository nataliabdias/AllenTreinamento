using Sample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Sample.Infra.Mapping
{
    public class EnderecoMapping : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMapping()
        {
            this.ToTable("Endereco");
            this.HasKey(x => x.Id);

            this.Property(x => x.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.Logradouro).HasColumnName("Logradouro").IsRequired().HasMaxLength(60);
            this.Property(x => x.Bairro).HasColumnName("Bairro").IsRequired().HasMaxLength(60);
            this.Property(x => x.CEP).HasColumnName("CEP").IsRequired().HasMaxLength(60);
            this.Property(x => x.Cidade).HasColumnName("Cidade").IsRequired().HasMaxLength(60);
            this.Property(x => x.Estado).HasColumnName("Estado").IsRequired().HasMaxLength(60);
            this.Property(x => x.Pais).HasColumnName("Pais").IsRequired().HasMaxLength(60);
            this.Property(x => x.IdPessoa).HasColumnName("IdPessoa");

        }
    }
}