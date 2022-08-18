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
                .HasColumnName("Id")
                .IsRequired();
            builder.Property(x => x.Name)
                .HasColumnName("Name");
            builder.Property(x => x.ShipCode)
                .HasColumnName("ShipCode");
            builder.Property(x => x.TypeName)
                .HasColumnName("TypeName");
            builder.Property(x => x.StatusName)
                .HasColumnName("StatusName");
            builder.Property(x => x.Owner)
                .HasColumnName("Owner");
            builder.Property(x => x.CreatDate)
                .HasColumnName("CreatDate");
            builder.Property(x => x.ModifyDate)
                .HasColumnName("ModifyDate");
            builder.Property(x => x.PushFlag)
                .HasColumnName("PushFlag");
            builder.Property(x => x.Type)
                .HasColumnName("Type");
            builder.Property(x => x.DeleteFlag)
                .HasColumnName("DeleteFlag");
        }
    }
}
