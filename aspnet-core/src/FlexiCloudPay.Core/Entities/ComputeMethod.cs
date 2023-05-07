using Abp.Domain.Entities;
using Castle.MicroKernel.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexiCloudPay.Entities
{
    [Table("ComputeMethod")]
    public class ComputeMethod: Entity<int>
    {
        [MaxLength(2)]
        public string methodcode { get; set; }

        [MaxLength(100)]
        public string description { get; set; }


        //1: Month
        //2: Day
        //3: Hour
        public int payrate { get; set; }


        //1:
        //2:

        public int roundinterm { get; set; }

        public int roundfinal { get; set; }


        [MaxLength(2)]
        //Cycle 
        public string cycle1 { get; set; }

        [MaxLength(3)]
        public string CutOffStart1 { get; set; }

        [MaxLength(3)]
        public string CutOffEnd1 { get; set;   }

        public decimal basicfactor1 { get; set; }

        public bool epf1 { get; set; }

        public bool socso1 { get; set; }

        public bool eis1 { get; set; }

        public bool tax1 { get; set; }

        public bool recal1 { get; set; }




        [MaxLength(2)]
        //Cycle 
        public string cycle2 { get; set; }

        [MaxLength(3)]
        public string CutOffStart2 { get; set; }

        [MaxLength(3)]
        public string CutOffEnd2 { get; set; }

        public decimal basicfactor2 { get; set; }

        public bool epf2 { get; set; }

        public bool socso2 { get; set; }

        public bool eis2 { get; set; }

        public bool tax2 { get; set; }

        public bool recal2 { get; set; }



        [MaxLength(2)]
        //Cycle 
        public string cycle3 { get; set; }

        [MaxLength(3)]
        public string CutOffStart3 { get; set; }

        [MaxLength(3)]
        public string CutOffEnd3 { get; set; }

        public decimal basicfactor3 { get; set; }

        public bool epf3 { get; set; }

        public bool socso3 { get; set; }

        public bool eis3 { get; set; }

        public bool tax3 { get; set; }

        public bool recal3 { get; set; }



        [MaxLength(2)]
        //Cycle 
        public string cycle4 { get; set; }

        [MaxLength(3)]
        public string CutOffStart4 { get; set; }

        [MaxLength(3)]
        public string CutOffEnd4 { get; set; }

        public decimal basicfactor4 { get; set; }

        public bool epf4 { get; set; }

        public bool socso4 { get; set; }

        public bool eis4 { get; set; }

        public bool tax4 { get; set; }

        public bool recal4 { get; set; }



        [MaxLength(2)]
        //Cycle 
        public string cycle5 { get; set; }

        [MaxLength(3)]
        public string CutOffStart5 { get; set; }

        [MaxLength(3)]
        public string CutOffEnd5 { get; set; }

        public decimal basicfactor5 { get; set; }

        public bool epf5 { get; set; }

        public bool socso5 { get; set; }

        public bool eis5 { get; set; }

        public bool tax5 { get; set; }

        public bool recal5 { get; set; }

        //97:
        //98:
        //99:
        //100:

        
        public int IncProrate { get; set; }

        public int NRProrate { get; set; }



    }
}
