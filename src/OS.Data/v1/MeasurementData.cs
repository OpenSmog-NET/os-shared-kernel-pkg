using Marten.Schema;
using System;

namespace OS.Data.v1
{
    /// <summary>
    /// MeasurementData is the storage entity class for Marten.
    /// </summary>
    public class MeasurementData : Dto.Data
    {
        public MeasurementData()
        {
        }

        /// <summary>
        /// Entity's Id
        /// </summary>
        [Identity]
        public Guid Id { get; set; }

        /// <summary>
        /// The UNIX Timestamp of when the measurement was taken
        /// </summary>
        public long TimeStamp { get; set; }

        /// <summary>
        /// The model's version
        /// </summary>
        public string Version { get; set; } = "1.0";

        /// <summary>
        /// The Id of the device
        /// </summary>
        public Guid DeviceId { get; set; }
    }
}