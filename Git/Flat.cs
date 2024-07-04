namespace Git
{
    internal class Flat
    {
        private uint number;
        private byte citizens;
        private byte floor;

        public Flat(uint number, byte citizens = 1, byte floor = 1)
        {
            this.number = number;
            this.citizens = citizens;
            this.floor = floor;
        }
    }
}
