# Adapter Pattern

## Purpose
Converts the interface of a class into another interface that clients expect.
Adapter lets incompatible classes work together without modifying their code.

## Benefits
- Allows reuse of existing (legacy) code
- Decouples client code from specific implementations
- Makes incompatible interfaces work together
- Supports Open/Closed Principle

## When to Use
- When you need to integrate legacy or third-party code
- When an existing class has an incompatible interface
- When you want to reuse existing functionality without modifying it

## Structure
```
                +------------------+
                |      Client      |
                +---------+--------+
                          |
                          v
                +------------------+
                |     Target        |
                | + Request()       |
                +---------+--------+
                          |
                          v
                +------------------+
                |     Adapter       |
                | + Request()       |
                +---------+--------+
                          |
                          v
                +--------------------+
                |     Adaptee        |
                | + SpecificRequest()|
                +--------------------+
```
## Example
A Unity example where OldEnemy has an incompatible method (AttackOldWay),
and EnemyAdapter converts it into a unified IEnemy interface with Attack().
The adapter also extends behavior by adding new logic on top of the old system.