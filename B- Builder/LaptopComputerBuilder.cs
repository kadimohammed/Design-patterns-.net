namespace B__Builder
{
    public class LaptopComputerBuilder : IComputerBuilder
    {
        private Computer computer = new Computer();

        public IComputerBuilder SetProcessor(string processor)
        {
            computer.Processor = processor + " (Mobile)";
            return this;
        }

        public IComputerBuilder SetMemory(int memory)
        {
            computer.Memory = memory;
            return this;
        }

        public IComputerBuilder SetStorage(string storage)
        {
            computer.Storage = storage + " (SSD)";
            return this;
        }

        public IComputerBuilder SetGraphicsCard()
        {
            computer.GraphicsCard = "Integrated Graphics";
            return this;
        }

        public Computer Build()
        {
            return computer;
        }
    }
}
