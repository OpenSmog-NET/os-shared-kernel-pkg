using System;

namespace OS.Sensors
{
    public class Device
    {
        public static Device Create(DeviceType type, string ownerId = null, string externalId = null)
        {
            return new Device()
            {
                Id = Guid.NewGuid(),
                Type = type,
                OwnerId = ownerId,
                ExternalId = externalId
            };
        }

        public static Device Create(DeviceType type, Guid id, string ownerId = null, string externalId = null)
        {
            return new Device()
            {
                Id = id,
                Type = type,
                OwnerId = ownerId,
                ExternalId = externalId
            };
        }

        /// <summary>
        /// The OpenSmog DeviceId
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The Id of the Owner
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// The external Id of the sensor (if applicable)
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// The address of the device (if applicable)
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// The Type of the Device
        /// </summary>
        public DeviceType Type { get; set; }

        /// <summary>
        /// The Geographical location of the device
        /// </summary>
        public Location Location { get; set; }

        public Device SetLocation(double longitude, double latitude)
        {
            if (this.Location == null)
            {
                Location = new Location();
            }

            Location.Longitude = longitude;
            Location.Latitude = latitude;

            return this;
        }

        public Device SetAddress(string address)
        {
            this.Address = address;

            return this;
        }
    }
}
