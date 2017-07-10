using System;

namespace OS.Sensors
{
    public class DeviceAggregate
    {
        public static DeviceAggregate Create(DeviceType type, string ownerId = null, string externalId = null)
        {
            return new DeviceAggregate()
            {
                Id = Guid.NewGuid(),
                Type = type,
                OwnerId = ownerId,
                ExternalId = externalId
            };
        }

        /// <summary>
        /// The OpenSmog DeviceId
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// The Id of the Owner
        /// </summary>
        public string OwnerId { get; private set; }

        /// <summary>
        /// The external Id of the sensor (if applicable)
        /// </summary>
        public string ExternalId { get; private set; }

        /// <summary>
        /// The address of the device (if applicable)
        /// </summary>
        public string Address { get; private set; }

        /// <summary>
        /// The Type of the Device
        /// </summary>
        public DeviceType Type { get; private set; }

        /// <summary>
        /// The Geographical location of the device
        /// </summary>
        public Location Location { get; private set; }

        public DeviceAggregate SetLocation(double longitude, double latitude)
        {
            if (this.Location == null)
            {
                Location = new Location();
            }

            Location.Longitude = longitude;
            Location.Latitude = latitude;

            return this;
        }

        public DeviceAggregate SetAddress(string address)
        {
            this.Address = address;

            return this;
        }
    }
}
