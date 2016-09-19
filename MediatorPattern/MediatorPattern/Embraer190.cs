namespace MediatorPattern
{
    internal class Embraer190 : Aircraft
    {
        public Embraer190(string callSign, IAirTrafficControl atc) : base (callSign, atc)
        {

        }

        public override int Ceiling => 35000;
    }
}