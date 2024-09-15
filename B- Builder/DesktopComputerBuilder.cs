namespace B__Builder
{
    public class DesktopComputerBuilder : IComputerBuilder
    {
        private Computer computer;

        public DesktopComputerBuilder()
        {
            computer = new Computer();
        }

        public IComputerBuilder SetProcessor(string processor)
        {
            computer.Processor = processor;
            return this;
        }

        public IComputerBuilder SetMemory(int memory)
        {
            computer.Memory = memory;
            return this;
        }

        public IComputerBuilder SetStorage(string storage)
        {
            computer.Storage = storage;
            return this;
        }

        public IComputerBuilder SetGraphicsCard()
        {
            computer.GraphicsCard = "Dedicated Graphics";
            return this;
        }

        public Computer Build()
        {
            return computer;
        }
    }
}
