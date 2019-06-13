using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MediaCampaign.Models
{
    public class Campaign
    {
        private string CompanyName;
        private string CampaignName;
        private string CampaignType;
        private int StartDate;
        private int EndDate;

        [DisplayName("Company Name")]
        public string CompanyName1 { get => CompanyName; set => CompanyName = value; }
        [DisplayName("Campaign Name")]
        public string CampaignName1 { get => CampaignName; set => CampaignName = value; }
        [DisplayName("Campaign Type")]
        public string CampaignType1 { get => CampaignType; set => CampaignType = value; }
        [DisplayName("Start Date")]
        public int StartDate1 { get => StartDate; set => StartDate = value; }
        [DisplayName("End Date")]
        public int EndDate1 { get => EndDate; set => EndDate = value; }
        
    }
}