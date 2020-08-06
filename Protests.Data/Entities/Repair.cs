using Protests.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Protests.Data
{
    public class Repair : BaseEntity
    {
        public long CarId { get; set; }

        public long RepairOptionId { get; set; }

        public DateTime? RepairedAt { get; set; }
    }
}
