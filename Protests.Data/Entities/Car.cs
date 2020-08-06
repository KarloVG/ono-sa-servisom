using Protests.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Protests.Data
{
    public class Car : BaseEntity
    {
        [Required]
        public string LicencePlate { get; set; }

        public long DriverId { get; set; }
    }
}
