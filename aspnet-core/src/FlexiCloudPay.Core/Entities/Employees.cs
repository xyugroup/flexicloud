using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexiCloudPay.Entities
{
    [Table("Employee")]
    public class Employees: Entity<int>
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

        

    }
}
