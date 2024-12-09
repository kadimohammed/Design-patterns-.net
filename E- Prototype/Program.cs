using E__Prototype;

Forme cerclePrototype = new Forme
{
    Type = "Cercle",
    Couleur = "Rouge"
};

Console.WriteLine("Prototype original :");
Console.WriteLine(cerclePrototype);


var copieCercle = cerclePrototype.Clone();
copieCercle.Couleur = "Bleu"; // Modification de la couleur dans le clone

Console.WriteLine("\nClone modifie :");
Console.WriteLine(copieCercle);

Console.WriteLine("\nPrototype original reste inchange :");
Console.WriteLine(cerclePrototype);