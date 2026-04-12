# Chain of Responsibility Pattern

## Purpose
Allows passing a request along a chain of handlers.
Each handler decides whether to process the request or pass it to the next handler in the chain.

## Benefits
- Decouples sender and receiver
- Simplifies complex conditional logic
- Allows dynamic composition of processing pipelines
- Makes it easy to add or remove handlers

## When to Use
- When multiple objects can handle a request
- When the order of processing matters
- When you want to avoid large if/switch statements
- When building pipelines (e.g., damage, validation, filters)

## Structure
```
 +------------------+
                |      Client      |
                +---------+--------+
                          |
                          v
                +------------------+
                |     Handler       |
                | + Handle()        |
                | + SetNext()       |
                +---------+--------+
                          |
            +-------------+-------------+
            |                           |
            v                           v
+---------------------+     +---------------------+
| ConcreteHandlerA    |     | ConcreteHandlerB    |
| + Handle()          |     | + Handle()          |
+----------+----------+     +----------+----------+
           |                           |
           v                           v
     +-----------+               +-----------+
     |  Request  |               |  Request  |
     +-----------+               +-----------+
```

## Example
A Unity example where incoming damage is processed through a chain of handlers such as ShieldHandler, 
ArmorHandler, and HealthHandler.
Each handler modifies or consumes the damage and passes the remaining value to the next handler, 
forming a flexible damage processing pipeline.