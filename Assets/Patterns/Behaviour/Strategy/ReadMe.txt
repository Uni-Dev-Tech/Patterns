# Strategy Pattern

## Purpose
Defines a family of algorithms, encapsulates each one, and makes them interchangeable.
Strategy lets the algorithm vary independently from clients that use it.

## Benefits
- Eliminates complex conditional logic
- Supports Open/Closed Principle
- Allows runtime behavior switching

## When to Use
- When a class has multiple possible behaviors.
- When behavior should be selected at runtime.
- When large conditional statements make the code difficult to maintain.

## Structure
```

	            +------------------+
                |      Client      |
                +---------+--------+
                          |
                          v
                +------------------+
                |      Context     |
                |  - strategy      |
                +---------+--------+
                          |
                          v
                  +---------------+
                  |   Strategy    |
                  |  (interface)  |
                  +-------+-------+
                          |
        +-----------------+-----------------+
        |                 |                 |
        v                 v                 v
+---------------+ +---------------+ +---------------+
|   StrategyA   | |   StrategyB   | |   StrategyC   |
+---------------+ +---------------+ +---------------+

```

## Example
A basic Unity implementation demonstrating how a Context can switch
between different strategies at runtime using keyboard input.