using CoreProject.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreProject.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .HasMaxLength(32)
                .IsRequired();

            builder.Property(x => x.Name)
                .HasColumnName("name");

            builder.Property(x => x.Mobile)
                .HasColumnName("mobile");

            builder.Property(x => x.Password)
            .HasColumnName("password");

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
