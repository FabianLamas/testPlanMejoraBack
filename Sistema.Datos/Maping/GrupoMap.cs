using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Entidades.DataEntidades;

namespace Sistema.Datos.Maping
{
    public class GrupoMap : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.ToTable("Grupos", "dbo").HasKey(g => g.ID);
        }
    }
}
