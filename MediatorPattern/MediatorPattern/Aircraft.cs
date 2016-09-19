using System;

namespace MediatorPattern
{
    public abstract class Aircraft
    {
        private readonly IAirTrafficControl _atc;
        private int _currentAltitude;

        protected Aircraft(string callSign, IAirTrafficControl atc)
        {
            _atc = atc;
            CallSign = callSign;
            _atc.RegisterAircraftUnderGuidance(this);
        }

        public abstract int Ceiling { get; }

        public string CallSign { get; }

        public int Altitude
        {
            get { return _currentAltitude; }
            set
            {
                _currentAltitude = value;
                _atc.ReceiveAircraftLocation(this);
            }
        }

        internal void WarnOfAirspaceIntrusion(Aircraft reportingAircraft)
        {
            Console.WriteLine("Two planes are close.");
        }

        public void Climb(int heightToClimb) => Altitude += heightToClimb;

        public override bool Equals(object obj) => base.Equals(obj);

        public override int GetHashCode() => CallSign.GetHashCode();
    }
}