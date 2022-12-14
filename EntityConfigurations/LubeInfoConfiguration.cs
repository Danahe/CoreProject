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
                .HasColumnName("id")
                .HasMaxLength(32)
                .IsRequired();

            builder.Property(x => x.Type)
                .HasColumnName("type");

            builder.Property(x => x.No)
                .HasColumnName("no");

            builder.Property(x => x.Model)
                .HasColumnName("model");

            builder.Property(x => x.Unit)
            .HasColumnName("unit");

            builder.Property(x => x.Brand)
             .HasColumnName("brand");

            builder.Property(x => x.Remark)
                .HasColumnName("remark");

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
