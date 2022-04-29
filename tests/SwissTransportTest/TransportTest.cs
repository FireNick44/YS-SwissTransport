namespace SwissTransport
{
    using System;
    using FluentAssertions;
    using SwissTransport.Core;
    using SwissTransport.Models;
    using Xunit;

    public class TransportTest
    {
        private readonly ITransport testee;

        public TransportTest()
        {
            this.testee = new Transport();
        }

        [Fact]
        public void Locations()
        {
            Stations stations = this.testee.GetStations("Sursee,");

            stations.StationList.Should().HaveCount(10);
        }

        [Fact]
        public void StationBoard()
        {
            StationBoardRoot stationBoard = this.testee.GetStationBoard("Sursee", "8502007");

            stationBoard.Should().NotBeNull();
        }

        [Fact]
        public void Connections()
        {
            DateTime date = DateTime.Now;
            DateTime time = DateTime.Now;
            bool isArrivalTime = false;
            Connections connections = this.testee.GetConnections("Sursee", "Luzern", date, time, isArrivalTime);

            connections.Should().NotBeNull();
        }
    }
}