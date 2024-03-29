﻿using System;
using System.Collections.Generic;

namespace AQBooking.Admin.Infrastructure.Databases.YachtEntities
{
    public partial class YachtMerchantFileStreams
    {
        public long Id { get; set; }
        public int MerchantFid { get; set; }
        public int FileTypeFid { get; set; }
        public int FileStreamFid { get; set; }
        public bool Deleted { get; set; }
        public DateTime ActivatedDate { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
