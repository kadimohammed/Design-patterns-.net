
using J__Template;

// Processing a text file
FileProcessor textProcessor = new TextFileProcessor();
textProcessor.ProcessFile("file.txt");

Console.WriteLine("\n");

// Processing a CSV file
FileProcessor csvProcessor = new CsvFileProcessor();
csvProcessor.ProcessFile("file.csv");