using System;
using System.Collections.Generic;
using System.Text;
using Infrastructur.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructur.EntityConfigurations
{
    public class DocumentEntityDBConfiguration : 
        IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            //Setting the table name
            builder.ToTable("Documents");

            //Setting the primary key
            builder.HasKey(x => x.Id);

            //Setting auto generations of id set from sql db
            builder.Property(x => x.Id).ForSqlServerUseSequenceHiLo();

            //Setting fileds
            builder.Property(x => x.Path).IsRequired();

        }
    }
}
