using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceMonitor
{
    class RaceMonitor : ICarCoordinates
    {
        #region data
        /// <summary>
        /// the singleton instance
        /// </summary>
        private static readonly RaceMonitor instance = new RaceMonitor();
        /// <summary>
        /// handler for the MQTT connection
        /// </summary>
        private readonly MqttRaceClient client;
        #endregion

        /// <summary>
        /// The instance of the RaceMonitor that manages to the Mqtt message processing.
        /// </summary>
        public static RaceMonitor Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// private for singleton implementation
        /// </summary>
        private RaceMonitor()
        {
            client = new MqttRaceClient();
            MqttRaceClient.RaceDataHandler = this;
        }

        /// <summary>
        /// establish a connection
        /// </summary>
        internal void Connect()
        {
            client.Connect();
        }


        // temporary variables to test the behaviour of the MqttRaceClient class.
        // TODO replace with a more meaningful race model
        static int speed = 0;
        static int position = 0;
        static Random random = new Random();

        /// <summary>
        /// implementation of the ICarCoordinates interface
        /// </summary>
        /// <param name="coords">car coordinate data</param>
        public void ProcessRaceData(JCarCoords coords)
        {
            // TODO replace with a more meaningful race model

            // received new car coordinates
            // store the information - Car array
            // calculate speed & publish
            speed++;
            speed %= 300;
            client.SendSpeed(coords.Timestamp, coords.CarIndex, speed);
            // calculate posision & publish
            position = random.Next(1, 6);
            client.SendPosition(coords.Timestamp, coords.CarIndex, position);
            // identify interesting events & publish
            if (speed == 1)
            {
                client.SendRaceEvent(coords.Timestamp, $"event {position}");
            }
        }

        public override string ToString()
        {
            // TODO show useful data
            return base.ToString();
        }
    }
}
