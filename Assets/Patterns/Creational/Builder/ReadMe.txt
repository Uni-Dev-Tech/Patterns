# Builder Pattern

## Purpose
Separates the construction of a complex object from its representation.
Builder allows step-by-step object creation with control over its internal state.

## Benefits
- Simplifies creation of complex objects
- Ensures object consistency
- Allows readable and fluent configuration
- Prevents invalid state changes after object is built

## When to Use
- When an object has many optional parameters
- When object construction is complex or requires multiple steps
- When you want to provide a clean and readable API for object creation

## Structure
```
            +------------------+
            |      Client      |
            +---------+--------+
                      |
                      v
            +------------------+
            |      Builder     |
            |  - step methods  |
            +---------+--------+
                      |
                      v
              +----------------+
              |     Product    |
              |  - internal    |
              |  - immutable   |
              +----------------+
```

## Example
A simple example in Unity where a Weapon object is built step-by-step
with configurable parameters like damage, fire rate, attachments, and magazine size.