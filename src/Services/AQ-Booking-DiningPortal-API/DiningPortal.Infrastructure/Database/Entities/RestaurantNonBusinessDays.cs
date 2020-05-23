﻿using System;
using System.Collections.Generic;

namespace AQDiningPortal.Infrastructure.Database.Entities
{
    public partial class RestaurantNonBusinessDays
    {
        public int Id { get; set; }
        public int RestaurantFid { get; set; }
        public bool Deleted { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Recurring { get; set; }
        public string Remark { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }

        public virtual Restaurants Restaurant { get; set; }
    }
}