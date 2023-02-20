using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Authentication.Configurations.Entities
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "User",
                },
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "Admin",
                }
                /*new IdentityRole
                 {
                     Name = "",
                     NormalizedName = "",
                 } */

                );
        }
    }
}
