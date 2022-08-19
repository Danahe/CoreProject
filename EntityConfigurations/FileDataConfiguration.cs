using CoreProject.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreProject.EntityConfigurations
{
    public class FileDataConfiguration : IEntityTypeConfiguration<FileData>
    {
        public void Configure(EntityTypeBuilder<FileData> builder)
        {
            builder.ToTable("file_data");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .HasMaxLength(32)
                .IsRequired();

            builder.Property(x => x.Data)
                .HasColumnName("data");

            builder.Property(x => x.Name)
                .HasColumnName("name");

            builder.Property(x => x.FileFormat)
                .HasColumnName("file_format");

            builder.Property(x => x.CreateDate)
           .HasColumnName("create_date");

            builder.Property(x => x.ModifyDate)
            .HasColumnName("modify_date");

            builder.Property(x => x.PushFlag)
                .HasColumnName("push_flag");

            builder.Property(x => x.DeleteFlag)
            .HasColumnName("delete_flag");
        }
    }
}
