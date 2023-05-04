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
        public Boolean ComputePayroll(String iPeriod, int iCycle, String sEmpNo);
    }
}
