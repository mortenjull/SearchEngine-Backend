using System;
using System.Collections.Generic;
using System.Text;
using Infrastructur.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructur.EntityConfigurations
{
    public class SearchResultEntityDBConfiguration :
        IEntityTypeConfiguration<SearchResults>
    {
        public void Configure(EntityTypeBuilder<SearchResults> builder)
        {
            //Sets table name
            builder.ToTable("SearchResulta");

            //Sets the primary key
            builder.HasKey(x => x.Id);

            //Setting auto generations of id set from sql db
            builder.Property(x => x.Id).ForSqlServerUseSequenceHiLo();

            //Setting table fields
            builder.HasOne(x => x.Document).
                WithMany().
                HasForeignKey(x => x.DocumentId);

            builder.HasOne(x => x.SearchWord).
                WithMany().
                HasForeignKey(x => x.SearchWordId);
        }
    }
}
