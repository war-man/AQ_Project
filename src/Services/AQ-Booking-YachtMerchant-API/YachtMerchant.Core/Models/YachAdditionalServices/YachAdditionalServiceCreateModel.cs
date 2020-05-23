﻿using System;

namespace YachtMerchant.Core.Models.YachAdditionalServices
{
    public class YachAdditionalServiceCreateModel
    {
        public int MerchantFid { get; set; }
        public int AdditonalServiceTypeFid { get; set; }
        public string AdditonalServiceTypeResKey { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        //public bool IsActive { get; set; }
        public DateTime ActiveFrom { get; set; }
        public DateTime? ActiveTo { get; set; }
    }
}