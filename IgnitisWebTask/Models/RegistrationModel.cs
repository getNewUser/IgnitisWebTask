using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IgnitisWebTask.Models
{
    public class RegistrationModel
    {
        public Guid Id { get; set; }
        public bool IsRequiredContractWork { get; set; }
        public String ContractWorkAsignee { get; set; }
        public bool IsBusinessClient { get; set; }
        public String CalculationMethod { get; set; }
        public bool IsImportantClient { get; set; }

    }
}