using Abp.Application.Services;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Runtime.Caching;
using FlexiCloudPay.Entities;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexiCloudPay.Payrolls
{
    //Cycle 1: A1    
    //  2: A2
    //  3: A3
    //  4: A4
    //  5: B1
    //  6: B2
    //  7: B3
    //  8: B4
    //  9: 01
    // 10: 02
    // 11: 03
    // 12: 04
    // 13: 0E


    public class Payroll : ApplicationService, iPayroll
    {

        public enum Cycle
        {
            A1 = 1,
            A2 = 2,
            A3 = 3,
            A4 = 4,
            B1 = 5,
            B2 = 6,
            B3 = 7,
            B4 = 8,
            P1 = 9,
            P2 = 10,
            P3 = 11,
            P4 = 12,
            PE = 13

        }

        IRepository<GeneralSetup> _generalsetupRepository;

        IRepository<Employees> _employeesRepository;

        IRepository<PaySources> _paySourceResository;

        IRepository<ComputeMethod> _computeMethodRepository;

        public Payroll(IRepository<Employees> employeerepository, IRepository<PaySources> paySourceResository,
            IRepository<GeneralSetup> generalsetupRepository,IRepository<ComputeMethod> computeMethodRepository)
        {
            _generalsetupRepository = generalsetupRepository;
            _employeesRepository = employeerepository;
            _paySourceResository = paySourceResository;
            _computeMethodRepository = computeMethodRepository;

        }

        public async Task<bool> ComputePayroll(string sPeriod, int iCycle, string sEmpNo)
        {
            decimal basic;
            decimal basicpay;
            decimal OTSum = 0;
            decimal AllowSum = 0;
            decimal DeductSum = 0;
            decimal UPLSum = 0;

            decimal ORPDay;
            decimal ORPHour;
            decimal ot10;
            decimal ot15;
            decimal ot20;
            decimal ot30;

            decimal ot10amt;
            decimal ot15amt;
            decimal ot20amt;
            decimal ot30amt;

            int computemethod;
            decimal dFactor;
            bool bRecal = false ;

            decimal workday;
            decimal daywork;

            

            //var task = _employeesRepository.GetAllListAsync(e => e.EmpNo == sEmpNo);
            var task0 = GetGSetting();

            IEnumerable<DateTime> giDate = task0.Result.Select(mt => mt.PayrollStartDate);
            DateTime PayrollStart = giDate.First();

            DateTime CutOffStart;
            DateTime CutOffEnd;

            int iYear = 0;
            int iMonth = 0;

            GetYearMonth(sPeriod, out iYear, out iMonth);

            



            var task = GetEmployee(sEmpNo, sPeriod, iCycle);

            IEnumerable<decimal> bdet = task.Result.Select(mt => mt.Basic);
            basic = bdet.Sum();
                        
            IEnumerable<int> cmdet = task.Result.Select(mt => mt.ComputeMethod);
            computemethod = cmdet.First();

            //var task11 = GetComputeMethod();

            //IEnumerable<string> cmStartdet = task11.Result.Select(cm => cm.CutOffStart1);
            //string CutOffStart1 = cmStartdet.First();

            GetCurrentCutOff(sPeriod, iCycle, iYear, iMonth, computemethod, out CutOffStart, out CutOffEnd, out dFactor);

            //IEnumerable<string> cmEnddet = task11.Result.Select(cm => cm.CutOffEnd1);

            var task2 = CapturePaySource(sPeriod, iCycle, sEmpNo);

            IEnumerable<decimal> wddet = task2.Result.Select(ps => ps.workday);
            workday = wddet.Sum();

            IEnumerable<decimal> dwdet = task2.Result.Select(ps => ps.daywork);
            daywork = dwdet.Sum();

            IEnumerable<decimal> oth10det = task2.Result.Select(ps => ps.ot10);
            ot10 = oth10det.Sum();

            IEnumerable<decimal> oth15det = task2.Result.Select(ps => ps.ot15);
            ot15 = oth15det.Sum();

            IEnumerable<decimal> oth20det = task2.Result.Select(ps => ps.ot20);
            ot20 = oth20det.Sum();

            IEnumerable<decimal> oth30det = task2.Result.Select(ps => ps.ot30);
            ot30 = oth30det.Sum();

            //If Prorate 

            basicpay = basic * ( bRecal? 1 :dFactor);

            ORPDay = basicpay / (26);

            ORPHour = basicpay / (26 * 8);

            if (ot10 > 0 )
            {
                ot10amt = ot10 * ORPHour * 1;
                OTSum = OTSum + ot10amt;
            }

            if (ot15 > 0)
            {
                ot15amt = ot15 * ORPHour * (decimal)1.50;
                OTSum = OTSum + ot15amt;
            }

            if (ot20 > 0)
            {
                ot20amt = ot20 * ORPHour * 2;
                OTSum = OTSum + ot20amt;
            }

            if (ot30 > 0)
            {
                ot30amt = ot30 * ORPHour * 3;
                OTSum = OTSum + ot30amt;
            }

            return true;
        }

        public Task<List<Employees>> GetEmployee(string sEmpNo, String sPeriod, int iCycle)
        {

            var task = _employeesRepository.GetAllListAsync(e => e.EmpNo == sEmpNo);

            IEnumerable<decimal> bdet = task.Result.Select(mt => mt.Basic);
            decimal basic = bdet.Sum();


            return task;
        }

        public Task<List<PaySources>> CapturePaySource(String sPeriod, int iCycle, String sEmpNo)
        {

            var task = _paySourceResository.GetAllListAsync(e => e.period == sPeriod && e.cycle == iCycle && e.empno == sEmpNo);

            return task;
        }

        public Task<List<GeneralSetup>> GetGSetting()
        {
            var task = _generalsetupRepository.GetAllListAsync();

            return task;
        }

        public async Task<ComputeMethod> GetComputeMethod(int MethodCode)
        {
            

            
                var task = await _computeMethodRepository.FirstOrDefaultAsync(t => t.Id == MethodCode);
                //var task = await _computeMethodRepository.FirstOrDefaultAsync(t => t.methodcode == "M1");
                return task;
            
            

        }

        private void GetYearMonth(String sPeriod, out int iYear, out int iMonth)
        {
            //Get sPeriod, First character to fourth character assign to iYear, fifth to sixth character assign to iMonth
            iYear = Convert.ToInt32(sPeriod.Substring(0, 4));
            iMonth = Convert.ToInt32(sPeriod.Substring(4, 2));
            //if iMonth is less then 10 then " " & iMonth else iMonth
            // = iMonth < 10 ? "0" + iMonth.ToString() : iMonth.ToString();
        }

        private void GetCurrentCutOff(String sPeriod, int iCycle, int iYear, int iMonth, int iComputeMethod , out DateTime dCutOffStart, out DateTime dCutOffEnd, out Decimal dFactor)
        {
            string sCycle = Enum.GetName(typeof(Cycle), iCycle);
            string sCutOffStart = "";
            string sCutOffEnd = "";
            decimal dTempBasicFactor = 1;

            //var task = GetComputeMethod(iCycle);
            var task = GetComputeMethod(iComputeMethod);

            int n = 0;

            //get 1 to 4 character from sPeriod to iYear, and 5 to 6 to iMonth
            //Get sPeriod, First character to fourth character assign to iYear, fifth to sixth character assign to iMonth

            //iYear = Convert.ToInt32(sPeriod.Substring(0, 4));
            //iMonth = Convert.ToInt32(sPeriod.Substring(4, 2));

            //Cycle1
            //IEnumerable<string> cmdetind1 = task.Result.Select(t => t.cycle1);
            //string MethodCode1 = task.Result.cycle1;
            //string MethodCode1 = cmdetind1.First();

            //Cycle1
            string MethodCode1 = task.Result.cycle1;
            if (MethodCode1 == sCycle)
            {
                n = 1;

                sCutOffStart = task.Result.CutOffStart1;
                sCutOffEnd = task.Result.CutOffEnd1;
                dTempBasicFactor = task.Result.basicfactor1;
            }
            

            /*
            IEnumerable<string> cmdstart1 = task.Result.Select(t => t.CutOffStart1);
            sCutOffStart = cmdstart1.First();
            IEnumerable<string> cmdEnd1 = task.Result.Select(t => t.CutOffEnd1);
            sCutOffEnd = cmdEnd1.First();
            IEnumerable<decimal> cmdfactor1 = task.Result.Select(t => t.basicfactor1);
            dFactor = cmdfactor1.First();
            */


            //Cycle2
            string MethodCode2 = task.Result.cycle2;
            if (MethodCode2 == sCycle)
            {
                n = 2;

                sCutOffStart = task.Result.CutOffStart2;
                sCutOffEnd = task.Result.CutOffEnd2;
                dTempBasicFactor = task.Result.basicfactor2;
            }


            /*
            IEnumerable<string> cmdetind2 = task.Result.Select(t => t.cycle2);
            string MethodCode2 = cmdetind2.First();
            if (MethodCode2 == sCycle) { n = 2; }


            IEnumerable<string> cmdstart2 = task.Result.Select(t => t.CutOffStart2);
            sCutOffStart = cmdstart2.First();
            IEnumerable<string> cmdEnd2 = task.Result.Select(t => t.CutOffEnd2);
            sCutOffEnd = cmdEnd2.First();
            IEnumerable<decimal> cmdfactor2 = task.Result.Select(t => t.basicfactor2);
            dFactor = cmdfactor2.First();
            */

            //Cycle3
            string MethodCode3 = task.Result.cycle3;
            if (MethodCode3 == sCycle)
            {
                n = 3;

                sCutOffStart = task.Result.CutOffStart3;
                sCutOffEnd = task.Result.CutOffEnd3;
                dTempBasicFactor = task.Result.basicfactor3;
            }

            /*
            IEnumerable<string> cmdetind3 = task.Result.Select(t => t.cycle3);
            string MethodCode3 = cmdetind3.First();
            if (MethodCode3 == sCycle) { n = 3; }

            IEnumerable<string> cmdstart3 = task.Result.Select(t => t.CutOffStart3);
            sCutOffStart = cmdstart3.First();
            IEnumerable<string> cmdEnd3 = task.Result.Select(t => t.CutOffEnd3);
            sCutOffEnd = cmdEnd3.First();
            IEnumerable<decimal> cmdfactor3 = task.Result.Select(t => t.basicfactor3);
            dFactor = cmdfactor3.First();
            */


            //Cycle4
            string MethodCode4 = task.Result.cycle4;
            if (MethodCode4 == sCycle)
            {
                n = 4;

                sCutOffStart = task.Result.CutOffStart4;
                sCutOffEnd = task.Result.CutOffEnd4;
                dTempBasicFactor = task.Result.basicfactor4;
            }
            /*
            IEnumerable<string> cmdetind4 = task.Result.Select(t => t.cycle4);
            string MethodCode4 = cmdetind4.First();
            if (MethodCode4 == sCycle) { n = 4; }

            IEnumerable<string> cmdstart4 = task.Result.Select(t => t.CutOffStart4);
            sCutOffStart = cmdstart4.First();
            IEnumerable<string> cmdEnd4 = task.Result.Select(t => t.CutOffEnd4);
            sCutOffEnd = cmdEnd4.First();
            IEnumerable<decimal> cmdfactor4 = task.Result.Select(t => t.basicfactor4);
            dFactor = cmdfactor4.First();
            */


            //Cycle5
            string MethodCode5 = task.Result.cycle5;
            if (MethodCode5 == sCycle)
            {
                n = 5;

                sCutOffStart = task.Result.CutOffStart5;
                sCutOffEnd = task.Result.CutOffEnd5;
                dTempBasicFactor = task.Result.basicfactor5;
            }



            /*
            IEnumerable<string> cmdetind5 = task.Result.Select(t => t.cycle5);
            string MethodCode5 = cmdetind5.First();
            if (MethodCode5 == sCycle) { n = 5; }

            IEnumerable<string> cmdstart5 = task.Result.Select(t => t.CutOffStart5);
            sCutOffStart = cmdstart5.First();
            IEnumerable<string> cmdEnd5 = task.Result.Select(t => t.CutOffEnd5);
            sCutOffEnd = cmdEnd5.First();
            IEnumerable<decimal> cmdfactor5 = task.Result.Select(t => t.basicfactor5);
            dFactor = cmdfactor5.First();
            */

            dFactor = dTempBasicFactor;
            GetCutOff(iYear, iMonth, sCutOffStart, sCutOffEnd,out dCutOffStart,out dCutOffEnd);
        
        
        }

        private void GetCutOff(int iYear ,int iMonth, string sCutOffStart,string sCutOffEnd, out DateTime dCutOffStart,out DateTime dCutOffEnd)
        {
            dCutOffStart = DateTime.MinValue;
            dCutOffEnd = DateTime.MaxValue;

            dCutOffStart = GetDate(sCutOffStart, iYear, iMonth);
            dCutOffEnd = GetDate(sCutOffEnd, iYear, iMonth);


        }

        private DateTime GetDate(string sCutOffDate, int iYear, int iMonth )
        {
            DateTime sCutOffDateNew;

            if (sCutOffDate.Contains("+"))
            {
                // trim character "+"
                 sCutOffDate = sCutOffDate.Trim('+');

                 sCutOffDateNew = new DateTime(iYear,iMonth,1);
                 sCutOffDateNew = sCutOffDateNew.AddMonths(1);

                 //check if sCutOffDate is greater than the maximum date of the month
                 if (sCutOffDateNew.Day < Convert.ToInt32(sCutOffDate))
                 {
                        sCutOffDateNew = sCutOffDateNew.AddDays(-1);
                 }
                 else
                 {
                        sCutOffDateNew = new DateTime(iYear, iMonth, Convert.ToInt32(sCutOffDate));
                 }

                return sCutOffDateNew;
            }

            if (sCutOffDate.Contains("-"))
            {
                sCutOffDate = sCutOffDate.Trim('-');

                sCutOffDateNew = new DateTime(iYear, iMonth, 1);
                sCutOffDateNew = sCutOffDateNew.AddMonths(-1);

                //check if sCutOffDate is greater than the maximum date of the month
                if (sCutOffDateNew.Day < Convert.ToInt32(sCutOffDate))
                {
                    sCutOffDateNew = sCutOffDateNew.AddDays(-1);
                }
                else
                {
                    sCutOffDateNew = new DateTime(iYear, iMonth, Convert.ToInt32(sCutOffDate));
                }

                return sCutOffDateNew;
            }

            sCutOffDateNew = new DateTime(iYear, iMonth, Convert.ToInt32(sCutOffDate));
            return sCutOffDateNew;

        }

    }
}
