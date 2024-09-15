namespace B__Builder
{
    public interface IComputerBuilder
    {
        IComputerBuilder SetProcessor(string processor);
        IComputerBuilder SetMemory(int memory);
        IComputerBuilder SetStorage(string storage);
        IComputerBuilder SetGraphicsCard();
        Computer Build();
    }
}
