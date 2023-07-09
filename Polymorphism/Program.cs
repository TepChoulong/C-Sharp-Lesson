/*
polymorphism = Greek word that means to "have many forms"
               Objects can be identified by more than one type
               Ex. A Dog is also: Canine, Animal, Organism
*/

Apple apple = new Apple();
Banana banana = new Banana();
Pineapple pineapple = new Pineapple();

Fruit[] fruits = {apple, banana, pineapple};

foreach(Fruit fruit in fruits)
{
    // fruit.Sweet(); // This apple is sweet, This banana is sweet, This pineapple is sweet.
    // fruit.Tart(); // This pineapple is tart.
    fruit.Sour(); // This apple is sweet, This pineapple is sour.
}

class Fruit
{
    public virtual void Sweet()
    {

    }
    public virtual void Sour()
    {

    }
    public virtual void Tart()
    {

    }
}
class Apple:Fruit
{
    public override void Sweet()
    {
        Console.WriteLine("This apple is sweet.");
    }
    public override void Sour()
    {
        Console.WriteLine("This apple is sweet.");
    }
}
class Banana:Fruit
{
    public override void Sweet()
    {
        Console.WriteLine("This banana is sweet.");
    }
}
class Pineapple:Fruit
{
    public override void Sweet()
    {
        Console.WriteLine("This pineapple is sweet.");
    }
    public override void Sour()
    {
        Console.WriteLine("This pineapple is sour.");
    }
    public override void Tart()
    {
        Console.WriteLine("This pineapple is tart.");
    }
}
