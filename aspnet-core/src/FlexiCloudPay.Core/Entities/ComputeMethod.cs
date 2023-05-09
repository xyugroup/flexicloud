using Abp.Domain.Entities;
using Castle.MicroKernel.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
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

        public bool HRD1 { get; set; }

        public bool recal1 { get; set; }




        [MaxLength(2)]
        [AllowNull]
        //Cycle 
        public string cycle2 { get; set; }

        [MaxLength(3)]
        [AllowNull]
        public string CutOffStart2 { get; set; }

        [MaxLength(3)]
        [AllowNull]
        public string CutOffEnd2 { get; set; }
        [DefaultValue(0)]
        public decimal basicfactor2 { get; set; }

        [DefaultValue(true)]
        public bool epf2 { get; set; }

        [DefaultValue(true)]
        public bool socso2 { get; set; }

        [DefaultValue(true)]
        public bool eis2 { get; set; }

        [DefaultValue(true)]
        public bool tax2 { get; set; }

        [DefaultValue(true)]
        public bool HRD2 { get; set; }

        [DefaultValue(false)]
        public bool recal2 { get; set; }


        
        [MaxLength(2)]
        //Cycle 
        public string cycle3 { get; set; }

        [AllowNull]
        [MaxLength(3)]
        public string CutOffStart3 { get; set; }

        [AllowNull]
        [MaxLength(3)]
        public string CutOffEnd3 { get; set; }

        [DefaultValue(0)]
        public decimal basicfactor3 { get; set; }

        [DefaultValue(true)]
        public bool epf3 { get; set; }

        [DefaultValue(true)]
        public bool socso3 { get; set; }

        [DefaultValue(true)]
        public bool eis3 { get; set; }

        [DefaultValue(true)]
        public bool tax3 { get; set; }

        [DefaultValue(true)]
        public bool HRD3 { get; set; }

        [DefaultValue(false)]
        public bool recal3 { get; set; }


        [AllowNull]

        [MaxLength(2)]
        //Cycle 
        public string cycle4 { get; set; }

        [AllowNull]
        [MaxLength(3)]
        public string CutOffStart4 { get; set; }

        [AllowNull]
        [MaxLength(3)]
        public string CutOffEnd4 { get; set; }

        [DefaultValue(0)]
        public decimal basicfactor4 { get; set; }

        [DefaultValue(true)]
        public bool epf4 { get; set; }

        [DefaultValue(true)]
        public bool socso4 { get; set; }

        [DefaultValue(true)]
        public bool eis4 { get; set; }

        [DefaultValue(true)]
        public bool tax4 { get; set; }

        [DefaultValue(true)]
        public bool HRD4 { get; set; }

        [DefaultValue(false)]
        public bool recal4 { get; set; }



        [AllowNull]
        [MaxLength(2)]
        //Cycle 
        public string cycle5 { get; set; }

        [AllowNull]
        [MaxLength(3)]
        public string CutOffStart5 { get; set; }

        [AllowNull]
        [MaxLength(3)]
        public string CutOffEnd5 { get; set; }

        [DefaultValue(0)]
        public decimal basicfactor5 { get; set; }

        [DefaultValue(true)]
        public bool epf5 { get; set; }

        [DefaultValue(true)]
        public bool socso5 { get; set; }

        [DefaultValue(true)]
        public bool eis5 { get; set; }

        [DefaultValue(true)]
        public bool tax5 { get; set; }

        [DefaultValue(true)]
        public bool HRD5 { get; set; }

        [DefaultValue(false)]
        public bool recal5 { get; set; }

        //97:
        //98:
        //99:
        //100:


        [DefaultValue(99)]
        public int IncProrate { get; set; }

        [DefaultValue(99)]
        public int NRProrate { get; set; }

        //Add in Part 2nd 

        [DefaultValue(1)]
        public int NegativePayMethod { get; set; }

        //public bool WDayOffDay { get; set; }

        //public bool WDayRestDay { get; set; }

        //public bool WDayHoliday { get; set; }

        public int RoundORPMEthod  { get; set; }

        public decimal MaxPayForOT { get; set; }


        //OT1
        public int OT1F1 { get; set; }

        public int OT1F2 { get; set; }

        public int OT1F3 { get; set; }

        public int OT1F4 { get; set; }

        public int OT1F5 { get; set; }

        public int OT1RoundMethod { get; set; }


        //OT2
        public int OT2F1 { get; set; }

        
        public int OT2F2 { get; set; }

        
        public int OT2F3 { get; set; }

        
        public int OT2F4 { get; set; }

        public int OT2F5 { get; set; }

        public int OT2RoundMethod { get; set; }


        //OT3
        public int OT3F1 { get; set; }

        public int OT3F2 { get; set; }

        public int OT3F3 { get; set; }

        public int OT3F4 { get; set; }

        public int OT3F5 { get; set; }

        public int OT3RoundMethod { get; set; }


        /// <summary>
        //OT4
        /// </summary>
        public int OT4F1 { get; set; }

        public int OT4F2 { get; set; }

        public int OT4F3 { get; set; }

        public int OT4F4 { get; set; }

        public int OT4F5 { get; set; }

        public int OT4RoundMethod { get; set; }


        //OT5
        /// </summary>
        public int OT5F1 { get; set; }

        public int OT5F2 { get; set; }

        public int OT5F3 { get; set; }

        public int OT5F4 { get; set; }

        public int OT5F5 { get; set; }

        public int OT5RoundMethod { get; set; }


        //OT6
        /// </summary>
        public int OT6F1 { get; set; }

        public int OT6F2 { get; set; }

        public int OT6F3 { get; set; }

        public int OT6F4 { get; set; }

        public int OT6F5 { get; set; }

        public int OT6RoundMethod { get; set; }



        //OT7
        /// </summary>
        public int OT7F1 { get; set; }

        public int OT7F2 { get; set; }

        public int OT7F3 { get; set; }

        public int OT7F4 { get; set; }

        public int OT7F5 { get; set; }

        public int OT7RoundMethod { get; set; }


        //OT8
        /// </summary>
        public int OT8F1 { get; set; }

        public int OT8F2 { get; set; }

        public int OT8F3 { get; set; }

        public int OT8F4 { get; set; }

        public int OT8F5 { get; set; }

        public int OT8RoundMethod { get; set; }
    }
}
