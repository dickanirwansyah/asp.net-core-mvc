 using Microsoft.EntityFrameworkCore;
 using Microsoft.Extensions.Configuration;
 using System.IO;

 namespace MvcTest.Models 
 {

     public class DataContext : DbContext
     {
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");
            
            var configuration = builder.Build();
            /** KONEKSI DATABASE */
            optionsBuilder.UseMySql(configuration["ConnectionStrings:DefaultConnection"]);
         }

         public DbSet<Product> Products {get; set;}
     }

 }