using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexiCloudPay.Payrolls
{
    public class Payroll: ApplicationService, iPayroll
    {
        public bool ComputePayroll(string iPeriod, int iCycle, string sEmpNo)
        {
            return true;
        }

        

    }
}
