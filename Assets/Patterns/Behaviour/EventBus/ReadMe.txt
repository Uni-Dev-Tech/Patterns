# Event Bus Pattern

## Purpose
Provides a centralized mechanism for communication between loosely coupled systems.
Event Bus allows different parts of the application to publish and subscribe to 
events without direct dependencies.

## Benefits
- Decouples systems from each other
- Supports scalable event-driven architecture
- Allows multiple listeners for a single event
- Simplifies adding new reactive systems
- Enables state replay for late subscribers

## When to Use
- When multiple systems need to react to the same event.
- When systems should not depend on each other directly.
- When implementing UI, analytics, or achievements reactions.
- When broadcasting global or cross-system events.

## Structure
```
                +------------------+
                |    Publisher     |
                +---------+--------+
                          |
                          v
                +------------------+
                |     Event Bus     |
                +---------+--------+
                          |
      +-------------------+------------------------------------+
      |             |            |              |              |
      v             v            v              v              v
+-----------+ +-----------+ +-----------+ +-----------+ +--------------+
|     UI    | |    VFX    | |   Sound   | | Analytics | | Achievements |
+-----------+ +-----------+ +-----------+ +-----------+ +--------------+
```

## Example
A Unity example where a PlayerDeath event is published through an Event Bus,
and multiple systems such as UI, Analytics, and Achievements react independently
without direct references to the player system.