# Bridge Pattern

## Purpose
Separates an abstraction from its implementation so that both can vary independently.
Bridge allows combining different abstractions and implementations without creating many classes.

## Benefits
- Reduces class explosion
- Decouples abstraction from implementation
- Improves flexibility and scalability
- Supports Open/Closed Principle

## When to Use
- When you want to avoid a large number of similar classes
- When abstraction and implementation can evolve independently
- When you need to combine different variations of behavior

## Structure
```
                +------------------+
                |      Client      |
                +---------+--------+
                          |
                          v
                +------------------+
                |    Abstraction    |
                | + Operation()     |
                +---------+--------+
                          |
                          v
                +------------------+
                |   Implementor     |
                | + OperationImpl() |
                +---------+--------+
                          |
            +-------------+-------------+
            |                           |
            v                           v
+---------------------+     +---------------------+
| ConcreteImplA       |     | ConcreteImplB       |
| + OperationImpl()   |     | + OperationImpl()   |
+---------------------+     +---------------------+
```

## Example
A Unity example where Weapon is the abstraction,
and IWeaponFire defines the implementation of shooting behavior.
Classes like Pistol and Rifle can use different fire modes such as SingleShot or BurstFire,
allowing flexible combinations without creating multiple subclasses.