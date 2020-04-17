using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAthena.Models.CampaignViewModels
{
    public class CampaignReportData
    {
        public IEnumerable<Campaign> Campaigns { get; set; }
        public IEnumerable<Report> Reports { get; set; }

    }
}
