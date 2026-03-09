# Observer Pattern

## Purpose
Defines a one-to-many dependency between objects so that when one object changes state, 
all its dependents are notified and updated automatically.

Observer allows objects to subscribe to events and react when the publisher's state changes.

## Benefits
- Promotes loose coupling between publisher and subscribers
- Supports Open/Closed Principle
- Allows dynamic subscription and unsubscription
- Simplifies event-driven systems

## When to Use
- When multiple objects need to react to changes in another object.
- When you want to avoid tight coupling between systems.
- When implementing event-driven architectures (UI updates, VFX triggers, AI reactions).

## Structure
```

	            +------------------+
                |      Client      |
                +---------+--------+
                          |
                          v
                +------------------+
                |      Subject     |
                |  - observers     |
                +---------+--------+
                          |
                          v
                  +---------------+
                  |    Observer    |
                  |   (interface)  |
                  +-------+-------+
                          |
        +-----------------+-----------------+
        |                 |                 |
        v                 v                 v
+---------------+ +---------------+ +---------------+
|  ObserverA    | |  ObserverB    | |  ObserverC    |
+---------------+ +---------------+ +---------------+

```

## Example
A basic Unity implementation where a HealthPublisher notifies multiple observers such as a health bar UI, 
visual effects, and highlight systems whenever the character's health changes.