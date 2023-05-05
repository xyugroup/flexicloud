using Abp.Application.Services;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using FlexiCloudPay.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexiCloudPay.Payrolls
{
    public class Payroll: ApplicationService, iPayroll
    {
        IRepository<Employees> _employeesRepository;


        public Payroll(IRepository<Employees> employeerepository)
        {
            _employeesRepository = employeerepository;
            //_paySourceResository = paySourceResository;
            //_computeMethodRepository = computeMethodRepository;
            //_generalsetupRepository = generalsetupRepository;
        }

        public async Task<bool> ComputePayroll(string sPeriod, int iCycle, string sEmpNo)
        {

            //var task = _employeesRepository.GetAllListAsync(e => e.EmpNo == sEmpNo);

            var task = GetEmployee(sEmpNo, sPeriod, iCycle);

            IEnumerable<decimal> bdet = task.Result.Select(mt => mt.Basic);
            decimal basic = bdet.Sum();


            return true;
        }

        public Task<List<Employees>> GetEmployee(string sEmpNo, String sPeriod, int iCycle)
        {

            var task = _employeesRepository.GetAllListAsync(e => e.EmpNo == sEmpNo);

            IEnumerable<decimal> bdet = task.Result.Select(mt => mt.Basic);
            decimal basic = bdet.Sum();


            return task;
        }

    }
}
