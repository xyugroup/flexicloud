using Abp.Domain.Entities;
using Abp.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexiCloudPay.Entities
{
    [Table("Employee")]
    public class Employees : Entity<int>
    {
        //public int EmployeeId { get; set; }

        public string EmpNo { get; set; }
        public string Name { get; set; }

        public DateTime EffDate { get; set; }

        public int Type { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        
        public int Sex { get; set; }

        public decimal Basic { get; set; }

        public int Department { get; set; }

        public int ComputeMethod { get; set; }


        public int Title { get; set; }

        public int AccessCode { get; set; }

        [MaxLength(30)]
        public string NoICNew { get; set; }

        [MaxLength(30)]
        public string NoICOld { get; set; }


        //1: blue
        //2: red
        public int ColorIC { get; set; }

        public DateTime DOB { get; set; }

        [MaxLength(50)]
        public String PlaceOfBirth { get; set; }

        public int Bloodtype { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        [MaxLength(100)]
        public string Address1 { get; set; }

        [MaxLength(100)]
        public string Address2 { get; set; }


        [MaxLength(100)]
        public string Address3 { get; set; }

        public int PostCode { get; set; }

        [MaxLength(50)]
        public string State { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        public int Country { get; set; }

        public int Race { get; set; }

        public int Religion { get; set; }

        public int Nationality { get; set; }

        [MaxLength(20)]
        public string NoOfPassport { get; set; }

        public DateTime ExpiredOfPassport { get; set; }

        [MaxLength(20)]
        public string phoneno { get; set; }


        public DateTime ContractDate { get; set; }

        public DateTime ContractExpired { get; set; }

        [MaxLength(20)]
        public string PermitNo { get; set; }

        public DateTime PermitDate { get; set; }

        public DateTime PermitExpired { get; set; }

        public int ORPTable { get; set; }

        public int Bank { get; set; }

        public string BankAccout { get; set; }

        public string BankIC { get; set; }

        public int EmployeType { get; set; }

        public int PayMode { get; set; }

        public int Job { get; set; }

        public int Position { get; set; }

        public int Company { get; set; }

        public int Branch { get; set; }

        public int Division { get; set; }

        public int Section { get; set; }

        public int Line { get; set; }

        public int Category { get; set; }

        public int Grade { get; set; }

        public int Class { get; set; }

        public int Scale { get; set; }

        public int ShiftGroup { get; set; }

        public int CostCenter { get; set; }

        public int Charge { get; set; }

        [Precision(2)]
        public Decimal LastBasic { get; set; }

        public int Project { get; set; }

        [MaxLength(1024)]
        public string Photo { get; set; }

        public int YOSMethod { get; set; }

        public bool CreditedAlternateBank { get; set; }

        
        public int Bank2 { get; set; }

        [MaxLength(20)]
        public string BankAccount2 { get; set; }

        [MaxLength(20)]
        public string BankIC2 { get; set; }

        public int LeaveTable { get; set; }

        public int HolidayTable { get; set; }

        public bool AutoDeduct { get; set; }

        [MaxLength(30)]
        public string EisNo { get; set; }

        public int EISTable { get; set; }

        public string EISReference { get; set; }

        public bool EIS { get; set; }

        public bool EPF { get; set; }

        public bool SOCSO { get; set; }

        public bool TAX { get; set; }

        public bool HRD { get; set; }

        public string EPFNo { get; set; }

        public int EPFTable { get; set; }

        public int EPFReference { get; set; }

        [MaxLength(30)]
        public string EPFIC { get; set; }

        [MaxLength(30)]
        public string TaxNo { get; set; }

        public int TaxBranch { get; set; }

        public int TaxTable { get; set; }


        public int TaxReference { get; set; }

        public bool TaxByEmployee { get; set; }

        [MaxLength(30)]
        public string SocsoNo { get; set; }

        public int SOCSOTable { get; set; }

        [MaxLength(30)]
        public string SOCSOIC { get; set; }

        public int SOCSOReference { get; set; }















    }
}
