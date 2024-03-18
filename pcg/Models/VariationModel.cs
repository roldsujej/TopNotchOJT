﻿using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace pcg.Models
{
    public class VariationModel
    {
        public string Task { get; set; }
        public string TaskId { get; set; }
        public string Remarks { get; set; }
        public string Description { get; set; }
        public string Descquery { get; set; }
        public string Descvary { get; set; }
        public string Descdocreq { get; set; }
        public string AssignId { get; set; }
        public string SiteReqId { get; set; }
        public string AddedBy { get; set; }
        public string DateStart { get; set; }
        public string DateFwd { get; set; }
        public string DateRcv { get; set; }
        public string DateClr { get; set; }
    }
}
