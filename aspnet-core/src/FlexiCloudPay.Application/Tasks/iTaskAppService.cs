using FlexiCloudPay.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexiCloudPay.Tasks
{
    public interface iTaskAppService
    {
        public Task<List<MyEntity>> GetString(string name);
        //public List<MyEntity> GetString(string name);
        //public string GetString(string name);
    }
}
