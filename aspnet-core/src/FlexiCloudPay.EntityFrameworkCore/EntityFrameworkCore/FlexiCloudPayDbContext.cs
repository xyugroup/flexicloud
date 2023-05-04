using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FlexiCloudPay.Authorization.Roles;
using FlexiCloudPay.Authorization.Users;
using FlexiCloudPay.MultiTenancy;

namespace FlexiCloudPay.EntityFrameworkCore
{
    public class FlexiCloudPayDbContext : AbpZeroDbContext<Tenant, Role, User, FlexiCloudPayDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public FlexiCloudPayDbContext(DbContextOptions<FlexiCloudPayDbContext> options)
            : base(options)
        {
        }
    }
}
