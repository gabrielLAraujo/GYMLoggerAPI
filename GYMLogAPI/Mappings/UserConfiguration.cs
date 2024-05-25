using GYMLogAPI.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GYMLogAPI.Mappings
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            
            builder.ToTable("users","trainning");
            builder.HasKey(u => u.token);
            builder.Property(u => u.Name).HasColumnName("name");
            builder.Property(u => u.Email).HasColumnName("email");
            builder.Property(u => u.Password).HasColumnName("password");
           
        }
    }
}
