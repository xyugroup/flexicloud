﻿using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexiCloudPay.Entities
{
    public class MyEntity :Entity<int>
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
