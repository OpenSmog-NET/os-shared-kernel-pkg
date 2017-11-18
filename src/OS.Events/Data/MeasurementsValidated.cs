﻿using OS.Dto.v1;
using System;

namespace OS.Events.Data
{
    public class MeasurementsValidated : DomainEvent
    {
        public Guid DeviceId { get; set; }
        public Measurement[] Measurements { get; set; }
    }
}