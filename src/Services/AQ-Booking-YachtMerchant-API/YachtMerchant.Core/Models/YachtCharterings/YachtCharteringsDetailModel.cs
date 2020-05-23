﻿using System;
using System.Collections.Generic;
using System.Text;

namespace YachtMerchant.Core.Models.YachtCharterings
{
    public class YachtCharteringsDetailModel
    {
        public long Id { get; set; }
        public int YachtFid { get; set; }
        public string UniqueID { get; set; }
        public Guid? CustomerFid { get; set; }
        public int SourceFid { get; set; }
        public string SourceResKey { get; set; }
        public string YachtName { get; set; }
        public long CharteringFID { get; set; }
        public string SourceName { get; set; }
        public int YachtPortFid { get; set; }
        public string YachtPortName { get; set; }
        public string CustomerName { get; set; }
        public string ReservationEmail { get; set; }
        public string ContactNo { get; set; }
        public int Passengers { get; set; }
        public int? CountItem { get; set; } = 1; // relation 1:1 : Count total item in detail
        public int PricingTypeFid { get; set; }
        public string PricingType { get; set; }
        public string CustomerNote { get; set; }
        public string CurrencyCode { get; set; }
        public string CultureCode { get; set; }
        public double OriginalValue { get; set; }
        public double DiscountedValue { get; set; }
        public double PaymentValue { get; set; } = 0;
        public double GrandTotalValue { get; set; }
        public double PrepaidRate { get; set; }
        public double PrepaidValue { get; set; }
        public bool HaveAdditionalServices { get; set; }
        public bool HaveCrewsMember { get; set; }
        public bool HaveChef { get; set; }
        public DateTime CharterDateFrom { get; set; }
        public DateTime CharterDateTo { get; set; }
        public DateTime? BookingDate { get; set; }
        public int StatusFid { get; set; }
        public bool Processed { get; set; }
        public Guid? ProcessedBy { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public string ProcessedRemark { get; set; }
        public bool GotSpecialRequest { get; set; }
        public string SpecialRequestDescriptions { get; set; }
        public string CancelReason { get; set; }
    }
}