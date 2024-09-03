# Iterator-Pattern-Demo

## SOFTWARE DESIGN PATTERNS
Design patterns are reusable solutions to common problems in software design. They provide code reusability, standardization(shared language and understanding), efficiency(by using established patterns) and flexibility(patterns are abstract solutions and can have different implementations).
There are 3 types of design patterns:
1. Creational Design Pattern
2. Structural Design Pattern
3. Behavioral Design Pattern

# IteratorDesignPattern
This project demonstrates an example of Iterator Design Pattern which is an example of Behavioral Design Pattern. This pattern provides a way to access the elements of an aggregate object (like a list) sequentially without exposing its underlying representation. It defines a separate object, called an iterator, which encapsulates the details of traversing the elements of the aggregate, allowing the aggregate to change its internal structure without affecting the way its elements are accessed.
Regardless of the internal structure the elements can be accessed.

Iterator Pattern Demo module has:
1. ConcreteIterator class which inherits from IAbstractIterator:
    * Provides methods MoveNext(), First() and CurrentItem()
2. ConcreteAggregator class which inherits from IAggregator:
    * Provides method for CreateIterator() for the Collection object to be parsed.

## UML DIAGRAM