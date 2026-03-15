# Facade Pattern

## Purpose
Provides a simplified interface to a complex subsystem.
Facade hides the complexity of multiple classes and exposes a single entry point for the client.

## Benefits
- Reduces coupling between client and subsystem
- Simplifies interaction with complex systems
- Improves code readability
- Centralizes system orchestration

## When to Use
- When a system has many interconnected classes.
- When you want to provide a simple API over a complex subsystem.
- When you want to decouple clients from internal implementation details.

## Structure
```
                +------------------+
                |      Client      |
                +---------+--------+
                          |
                          v
                +------------------+
                |      Facade      |
                +---------+--------+
                          |
        +-----------------+-----------------+
        |                                   |
        v                                   v
+---------------+                 +---------------+
|   SubsystemA  |                 |   SubsystemB  |
+---------------+                 +---------------+
```

## Example
A simple Unity example where a Facade coordinates multiple subsystems.
The client interacts only with the Facade, which internally calls operations
from SubsystemA and SubsystemB.