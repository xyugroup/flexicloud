﻿using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FlexiCloudPay.Authorization.Roles;
using FlexiCloudPay.Authorization.Users;
using FlexiCloudPay.MultiTenancy;
using FlexiCloudPay.Entities;

namespace FlexiCloudPay.EntityFrameworkCore
{
    public class FlexiCloudPayDbContext : AbpZeroDbContext<Tenant, Role, User, FlexiCloudPayDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<MyEntity> MyEntity { get; set; }
        
        public FlexiCloudPayDbContext(DbContextOptions<FlexiCloudPayDbContext> options)
            : base(options)
        {
        }
    }
}
