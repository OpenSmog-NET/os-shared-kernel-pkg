using System;

namespace OS.Data.v1
{
    public static class MeasurementDataMapper
    {
        /// <summary>
        /// Performs mapping DTO to DAL
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="measurement"></param>
        /// <returns></returns>
        public static OS.Data.v1.MeasurementData MapToDAL(Guid deviceId, OS.Dto.v1.Measurement measurement)
        {
            var data = measurement.Data;

            return new OS.Data.v1.MeasurementData()
            {
                DeviceId = deviceId,
                TimeStamp = measurement.Timestamp,

                Temp = data.Temp,
                Hum = data.Hum,
                Press = data.Press,
                Pm10 = data.Pm10,
                Pm25 = data.Pm25,
                CO = data.CO,
                SO2 = data.SO2,
                NO2 = data.NO2,
                O3 = data.O3,
                Pb = data.Pb,
                Tvoc = data.Tvoc
            };
        }

        /// <summary>
        /// Performs mapping DAL to DTO
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static OS.Dto.v1.Measurement MapToDto(OS.Data.v1.MeasurementData data)
        {
            return new OS.Dto.v1.Measurement()
            {
                Timestamp = data.TimeStamp,
                Data = new Dto.v1.Data()
                {
                    Temp = data.Temp,
                    Hum = data.Hum,
                    Press = data.Press,
                    Pm10 = data.Pm10,
                    Pm25 = data.Pm25,
                    CO = data.CO,
                    SO2 = data.SO2,
                    NO2 = data.NO2,
                    O3 = data.O3,
                    Pb = data.Pb,
                    Tvoc = data.Tvoc
                }
            };
        }
    }
}