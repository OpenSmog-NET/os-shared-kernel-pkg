﻿using OS.Dto;
using System;

namespace OS.Events.Data
{
    public class SaveMeasurementsCommand : DomainEvent
    {
        public Guid DeviceId { get; set; }
        public Measurement[] Measurements { get; set; }
    }
}