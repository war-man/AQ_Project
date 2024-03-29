﻿using System;
using System.Collections.Generic;

namespace AQBooking.Admin.Infrastructure.Databases.YachtEntities
{
    public partial class YachtMerchants
    {
        public int Id { get; set; }
        public string UniqueId { get; set; }
        public int ZoneFid { get; set; }
        public string MerchantName { get; set; }
        public int MerchantTypeFid { get; set; }
        public string MerchantTypeResKey { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string ContactNumber1 { get; set; }
        public string ContactNumber2 { get; set; }
        public string EmailAddress1 { get; set; }
        public string EmailAddress2 { get; set; }
        public int AccountSize { get; set; }
        public DateTime ExpiredDate { get; set; }
        public int LandingPageOptionFid { get; set; }
        public string Remark { get; set; }
        public bool Deleted { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
