using LibCarService;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CarSercviceCenter.Orm.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User> {

        public void Configure(EntityTypeBuilder<User> builder) {
            builder.ToTable("User");

            builder.HasKey(user => user.Id);

            builder.Property(user => user.Id).ValueGeneratedOnAdd();
            builder.Property(user => user.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(user => user.Surname).HasMaxLength(50).IsRequired(true);
        }

        
    }
}