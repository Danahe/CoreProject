using CoreProject.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreProject.EntityConfigurations
{
    public class ShipInfoConfiguration:IEntityTypeConfiguration<ShipInfo>
    {
        public void Configure(EntityTypeBuilder<ShipInfo> builder)
        {
            builder.ToTable("ships");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired();
            builder.Property(x => x.Name)
                .HasColumnName("name");
            builder.Property(x => x.ShipCode)
                .HasColumnName("ship_code");
            builder.Property(x => x.TypeName)
                .HasColumnName("type_name");
            builder.Property(x => x.StatusName)
                .HasColumnName("status_name");
            builder.Property(x => x.Owner)
                .HasColumnName("owner");
            builder.Property(x => x.CreateDate)
                .HasColumnName("create_date");
            builder.Property(x => x.ModifyDate)
                .HasColumnName("modify_date");
            builder.Property(x => x.PushFlag)
                .HasColumnName("push_flag");
            builder.Property(x => x.Type)
                .HasColumnName("type");
            builder.Property(x => x.DeleteFlag)
                .HasColumnName("delete_flag");
        }
    }
}
