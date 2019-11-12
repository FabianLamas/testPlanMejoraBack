using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Entidades.DataEntidades;

namespace Sistema.Datos.Maping
{
    public class AuditDocumentMap : IEntityTypeConfiguration<AuditDocument>
    {
        public void Configure(EntityTypeBuilder<AuditDocument> builder)
        {
            builder.ToTable("AuditDocument", "dbo").HasKey(q => q.Id);
        }
    }
}
