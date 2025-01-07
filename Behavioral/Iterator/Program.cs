// The Iterator Design Pattern is a behavioral design pattern that provides a way to access the elements of an aggregate object (such as a collection) sequentially without exposing its underlying representation.

using Iterator;
using Iterator.Interfaces;

IAggregate<string> stringAggregate = new ConcreteAggregate<string>();
stringAggregate.AddItem("a");
stringAggregate.AddItem("b");
stringAggregate.AddItem("c");

var iterator = stringAggregate.CreateIterator();

while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}
