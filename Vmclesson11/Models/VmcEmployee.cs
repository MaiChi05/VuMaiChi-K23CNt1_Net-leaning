using System;
using System.Collections.Generic;

namespace Vmclesson11.Models
{
    public partial class VmcEmployee
    {
        public int VmcEmpId { get; set; }

        public string VmcEmpName { get; set; } = null!;

        public string? VmcEmpLevel { get; set; }

        public DateOnly? VmcEmpStartDate { get; set; }

        public bool? VmcEmpStatus { get; set; }
    }
}
