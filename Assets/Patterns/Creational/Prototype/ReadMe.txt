# Prototype Pattern

## Purpose
Allows creating new objects by copying an existing object, without depending on their concrete classes.
Prototype lets you duplicate complex objects efficiently.

## Benefits
- Avoids expensive or complicated object creation
- Supports cloning objects without knowing their exact types
- Makes it easy to create variations of existing objects
- Reduces dependency on concrete classes

## When to Use
- When creating a new object is costly or complex
- When you want to create many similar objects with slight differences
- When a system should be independent of how its objects are created, composed, and represented

## Structure
```
                +------------------+
                |      Client      |
                +---------+--------+
                          |
                          v
                +------------------+
                |     Prototype     |
                | + Clone()         |
                +---------+--------+
                          |
            +-------------+-------------+
            |                           |
            v                           v
     +-----------+               +-----------+
     | Concrete  |               | Concrete  |
     | PrototypeA|               | PrototypeB|
     | + Clone() |               | + Clone() |
     +-----------+               +-----------+
```
## Example
A Unity example where WeaponStats objects are cloned using a type-safe generic Clone method,
allowing you to create copies of weapon configurations without manually creating new instances.