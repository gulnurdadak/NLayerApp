using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "Pencil1",
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now
            },
            new Product
            {

                Id = 2,
                CategoryId = 1,
                Name = "Pencil2",
                Price = 500,
                Stock = 70,
                CreatedDate = DateTime.Now
            },

           new Product
           {
               Id = 3,
               CategoryId = 1,
               Name = "Pencil3",
               Price = 600,
               Stock = 80,
               CreatedDate = DateTime.Now
           },

           new Product
           {
               Id = 4,
               CategoryId = 2,
               Name = "Book1",
               Price = 467,
               Stock = 50,
               CreatedDate = DateTime.Now

           },
           new Product
           {
               Id = 5,
               CategoryId = 2,
               Name = "Book2",
               Price = 432,
               Stock = 43,
               CreatedDate = DateTime.Now

           });
           
        }
    }

}
