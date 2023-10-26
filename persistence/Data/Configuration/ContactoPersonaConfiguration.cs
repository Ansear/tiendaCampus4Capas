using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace persistence.Data.Configuration;
public class ContactoPersonaConfiguration : IEntityTypeConfiguration<ContactoPersona>
{
    public void Configure(EntityTypeBuilder<ContactoPersona> builder)
    {
        builder.ToTable("ContactoPersona");

        builder.HasKey(cp => cp.Id);
        builder.Property(cp => cp.Id);

        builder.HasOne(cp => cp.Personas).WithMany(cp => cp.ContactosPersonas).HasForeignKey(cp => cp.IdPersona);

        builder.HasOne(cp => cp.TiposContactos).WithMany(cp => cp.ContactosPersonas).HasForeignKey(cp => cp.IdTipoContacto);
    }
}