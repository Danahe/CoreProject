using CoreProject.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreProject.EntityConfigurations
{
    public class LubeInfoConfiguration : IEntityTypeConfiguration<LubeInfo>
    {
        public void Configure(EntityTypeBuilder<LubeInfo> builder)
        {
            builder.ToTable("LubeInfos");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .HasMaxLength(32)
                .IsRequired();

            builder.Property(x => x.Type)
                .HasColumnName("Type");

            builder.Property(x => x.No)
                .HasColumnName("No");

            builder.Property(x => x.Model)
                .HasColumnName("Model");

            builder.Property(x => x.Unit)
            .HasColumnName("Unit");

            builder.Property(x => x.Brand)
             .HasColumnName("Brand");

            builder.Property(x => x.Remark)
                .HasColumnName("Remark");

            builder.Property(x => x.CreatDate)
           .HasColumnName("CreatDate");

            builder.Property(x => x.ModifyDate)
            .HasColumnName("ModifyDate");

            builder.Property(x => x.PushFlag)
                .HasColumnName("PushFlag");

            builder.Property(x => x.DeleteFlag)
            .HasColumnName("DeleteFlag");
        }
    }
}
