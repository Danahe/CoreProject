using CoreProject.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreProject.EntityConfigurations
{
    public class MeasureDataConfiguration : IEntityTypeConfiguration<MeasureData>
    {
        public void Configure(EntityTypeBuilder<MeasureData> builder)
        {
            builder.ToTable("measuredatas");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .HasMaxLength(36)
                .IsRequired();

            builder.Property(x => x.Data)
                .HasColumnName("Data");
            builder.Property(x => x.ShipId)
                .HasColumnName("ship_id");

            builder.Property(x => x.FileFormat)
                .HasColumnName("FileFormat");

            builder.Property(x => x.CreatDate)
                .HasColumnName("CreatDate");

            builder.Property(x => x.ModifyDate)
                .HasColumnName("ModifyDate");

            builder.Property(x => x.DeleteFlag)
                .HasColumnName("DeleteFlag");

            builder.Property(x => x.PushFlag)
                .HasColumnName("PushFlag");
        }
    }
}
