# Factory Method Pattern

## Purpose
Defines an interface for creating objects, but lets subclasses decide which class to instantiate.
Factory Method lets a class defer object creation to subclasses.

## Benefits
- Encapsulates object creation logic
- Reduces coupling between client and concrete classes
- Supports Open/Closed Principle
- Makes code easier to extend with new types

## When to Use
- When a class cannot anticipate the type of objects it must create.
- When object creation logic should be separated from the client.
- When subclasses should control what objects get created.

## Structure
```
                +------------------+
                |      Client      |
                +---------+--------+
                          |
                          v
                +------------------+
                |      Creator      |
                | + Create()        |
                +---------+--------+
                          |
            +-------------+-------------+
            |                           |
            v                           v
+---------------------+     +---------------------+
|   ConcreteFactoryA  |     |   ConcreteFactoryB  |
|   + Create()        |     |   + Create()        |
+----------+----------+     +----------+----------+
           |                           |
           v                           v
     +-----------+               +-----------+
     | ProductA  |               | ProductB  |
     +-----------+               +-----------+
```

## Example
A Unity example where an EnemySpawner uses factories to create different enemy types,
such as zombies or robots, without directly depending on their concrete implementations.
Factories handle the instantiation and initialization of enemies.