﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    class Material
    {
        public string Name { get; private set; }
        public double ImportUnitPrice { get; private set; }
        public double ExportUnitPrice { get; private set; }
        public string Unit { get; private set; }
        public string Specialization { get; private set; }
    }
}
