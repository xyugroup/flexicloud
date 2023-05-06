using Abp.Domain.Entities;
using Abp.Extensions;
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
        public int EmployeeId { get; set; }

        public string EmpNo { get; set; }
        public string Name { get; set; }

        public DateTime EffDate { get; set; }

        public int Type { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }

        public int Sex { get; set; }

        public decimal Basic { get; set; }

        public int Department { get; set; }

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








    }
}
