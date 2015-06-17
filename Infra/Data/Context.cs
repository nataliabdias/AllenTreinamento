using Sample.Infra.Mapping;
using Sample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Sample.Infra.Data
{
    public class Context : DbContext
    {
        private const String CONNECTION_NAME = "DefaultConnection";

        public DbSet<User> Users { get; set; }

        public DbSet<Pessoa> Pessoas { get; set; }

        public Context()
            : base(CONNECTION_NAME)
        {
           // Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());

            Database.SetInitializer<Context>(null);

            this.Database.Log = (message) =>
            {
                Trace.WriteLine(message);
            };

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new EnderecoMapping());
            modelBuilder.Configurations.Add(new PessoaMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}