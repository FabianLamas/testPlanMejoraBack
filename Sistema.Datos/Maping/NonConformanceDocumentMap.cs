using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Entidades.DataEntidades;

namespace Sistema.Datos.Maping
{
    public class NonConformanceDocumentMap : IEntityTypeConfiguration<NonConformanceDocument>
    {
        public void Configure(EntityTypeBuilder<NonConformanceDocument> builder)
        {
            builder.ToTable("NonConformanceDocument", "dbo").HasKey(n => n.Id);
        }
    }
}
