using Sample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Sample.Infra.Mapping
{
    public class PessoaMapping : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMapping()
        {
            this.ToTable("Pessoa");
            this.HasKey(x => x.Id);

            this.Property(x => x.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.Nome).HasColumnName("Nome").IsRequired().HasMaxLength(60);
            this.Property(x => x.Email).HasColumnName("Email").IsRequired().HasMaxLength(500);
            this.Property(x => x.Cpf).HasColumnName("CPF").IsRequired().HasMaxLength(11);
            this.Property(x => x.DtNascimento).HasColumnName("DtNascimento").IsRequired();

            this.HasMany(x => x.Endereco).WithOptional().HasForeignKey(x => x.IdPessoa).WillCascadeOnDelete(true);

        }
    }
}