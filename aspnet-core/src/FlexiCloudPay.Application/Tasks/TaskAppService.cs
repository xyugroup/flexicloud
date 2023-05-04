using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using FlexiCloudPay.EntityFrameworkCore;
using FlexiCloudPay.Entities;
using Abp.Application.Services;
using Abp.Domain.Repositories;

namespace FlexiCloudPay.Tasks
{
    public class TaskAppService:ApplicationService, iTaskAppService
    {
        //private readonly FlexiCloudPayDbContext _context;
        private readonly IRepository<MyEntity> _myentity;


        //public TaskAppService(FlexiCloudPayDbContext context)
        public TaskAppService(IRepository<MyEntity> myentity)
        {
            //_context = context;
            _myentity = myentity;
        }

        public async Task<List<MyEntity>> GetString(string name)
        //public string GetString(string name)
        {
            var task = _myentity.GetAllListAsync(e => e.Name == name);

            return task.Result.ToList();
            //return "Hello, " + name;
            //return _context.MyEntity.ToList();
        }

    }
}
