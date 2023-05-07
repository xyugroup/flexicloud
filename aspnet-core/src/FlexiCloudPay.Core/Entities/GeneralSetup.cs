using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexiCloudPay.Entities
{
    [Table("GenralSetup")]
    public class GeneralSetup: Entity<int>
    {
        public DateTime PayrollStartDate { get; set; }

        public String CurrentPeriod { get; set; }


    }
}
