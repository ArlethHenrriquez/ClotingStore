using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ClotingStore.BL
{
    public class Contexto : DbContext
    {
        public Contexto() : base(@"Data Source =(LocalDb)\MSSQLLocalDB;AttachDBFilename="+
        Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ClotingStore.mdf")


        {
                
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Producto> Categorias  { get; set; }
        public DbSet<Categorias> Categoria  { get; set; }
    }
}
