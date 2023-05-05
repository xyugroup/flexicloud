using Abp.Domain.Entities;
using Abp.Threading.BackgroundWorkers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexiCloudPay.Entities
{
    [Table("PaySource")]
    public class PaySources: Entity<int>
    {
        public string period { get; set; }

        public int cycle { get; set; }

        public string empno { get; set; }

        public decimal workday { get; set; }

        public decimal daywork { get; set; }

        public decimal allow { get; set; }

        public decimal deduct { get; set; }

        public decimal ot10 { get; set; }

        public decimal ot15 { get; set; }

        public decimal ot20 { get; set; }

        public decimal ot30 { get; set; }

        public decimal absent { get; set; }


    }
}
