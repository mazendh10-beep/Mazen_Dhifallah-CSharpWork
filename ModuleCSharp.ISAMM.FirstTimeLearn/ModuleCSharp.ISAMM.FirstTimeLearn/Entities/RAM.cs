using ModuleC_.ISAMM.COCOJV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleCSharp.ISAMM.FirstTimeLearn.Entities
{
    public class RAM: BaseEntity
    {
        public string? Brand { get; set; }
        public int Capacity { get; set; }
        public int Speed { get; set; }
        public string ? Type { get; set; }
        public List<PcRam>? Pcs {get; set; }


    };
}
