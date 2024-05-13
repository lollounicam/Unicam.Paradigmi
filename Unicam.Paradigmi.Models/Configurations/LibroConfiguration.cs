using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unicam.Paradigmi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicam.Paradigmi.Models.Configurations
{
    public class LibroConfiguration : IEntityTypeConfiguration<Libro>
    {
        public void Configure(EntityTypeBuilder<Libro> builder)
        {
            builder.ToTable("Libro");
            builder.HasKey(x => x.id);
            builder.HasMany(p => p.categorie).WithOne().HasForeignKey(x => x.id);
            builder.HasMany(p => p.categorie).WithMany(p => p.libri)
                .UsingEntity("CategoriaLibro",
            l => l.HasOne(typeof(Categoria)).WithMany().HasForeignKey("categoriaid").HasPrincipalKey(nameof(Categoria.id)),
            r => r.HasOne(typeof(Libro)).WithMany().HasForeignKey("libroid").HasPrincipalKey(nameof(Libro.id)),
            j => j.HasKey("categoriaid", "libroid")); ;

        }
    }
}
