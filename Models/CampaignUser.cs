﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAthena.Models
{
    public class CampaignUser
    {
        [Key]
        public string Id { get; set; }
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public string ApplicationUserId { get; set; }
        public string ApplicationUserFullName { get; set; }

        //Relational
        public Campaign Campaign { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
