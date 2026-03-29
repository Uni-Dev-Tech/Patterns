# Decorator Pattern

## Purpose
Allows adding new behavior to an object dynamically without modifying its structure.
Decorator wraps an object and extends its functionality.

## Benefits
- Follows Open/Closed Principle
- Avoids large inheritance hierarchies
- Allows combining behaviors at runtime
- Promotes flexible and reusable code

## When to Use
- When you need to add responsibilities to objects dynamically
- When subclassing would lead to too many classes
- When you want to combine multiple behaviors in different ways

## Structure
```
                +------------------+
                |      Client      |
                +---------+--------+
                          |
                          v
                +------------------+
                |     Component     |
                | + Operation()     |
                +---------+--------+
                          |
            +-------------+-------------+
            |                           |
            v                           v
     +-----------+               +------------------+
     | Concrete  |               |    Decorator     |
     | Component |               | + Operation()    |
     +-----------+               +---------+--------+
                                           |
                                           v
                                  +------------------+
                                  | ConcreteDecorator|
                                  | + Operation()    |
                                  +------------------+
```

## Example
A Unity example where BasicEnemy implements IEnemy,
and decorators like PoisonDecorator and FireEffectDecorator wrap it to add new attack effects.
Multiple decorators can be combined at runtime to create complex behaviors without creating new classes.