﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace AQBooking.Admin.Infrastructure.Databases.EvisaEntities
{
    public partial class CountryVisaProcessOptions
    {
        public int Id { get; set; }
        public int CountryVisaProcesFid { get; set; }
        public string ProcessOptionsName { get; set; }
        public double ProcessingTime { get; set; }
        public int ProcessingTimeUnitFid { get; set; }
        public string ProcessingTimeUnitResKey { get; set; }
        public string Remark { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}