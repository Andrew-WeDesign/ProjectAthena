using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAthena.Models.ReportViewModel
{
    public class ReportData
    {
        public IEnumerable<Report> Reports { get; set; }
        public IEnumerable<ApplicationUser> ApplicationUsers { get; set; }
        public IEnumerable<Campaign> Campaigns { get; set; }

    }
}
