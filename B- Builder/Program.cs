

using B__Builder;

DesktopComputerBuilder desktopComputerBuilder = new DesktopComputerBuilder();

Computer c = desktopComputerBuilder.SetGraphicsCard().SetProcessor("i5").SetStorage("dell 1000").SetMemory(500).Build();

Console.WriteLine(c);