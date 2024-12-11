using K__Iterator;

BookCollection bookCollection = new BookCollection();
bookCollection.AddBook("Design Patterns");
bookCollection.AddBook("Clean Code");
bookCollection.AddBook("c#");


IIterator<string> iterator = bookCollection.CreateIterator();



while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}