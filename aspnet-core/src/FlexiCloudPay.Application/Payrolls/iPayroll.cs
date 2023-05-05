using Abp.Application.Services;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexiCloudPay.Payrolls
{
    public interface iPayroll: IApplicationService
    {
        public Task<bool> ComputePayroll(string sPeriod, int iCycle, string sEmpNo);
    }
}
