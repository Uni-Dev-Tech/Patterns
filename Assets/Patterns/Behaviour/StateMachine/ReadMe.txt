# State Pattern

## Purpose
Allows an object to alter its behavior when its internal state changes.
State lets state-specific behavior be represented as separate classes.

## Benefits
- Eliminates large conditional statements
- Encapsulates behavior for each state
- Makes transitions explicit and easier to manage
- Improves scalability for complex behaviors

## When to Use
- When an object behaves differently depending on its current state
- When logic is heavily based on state transitions
- When large if/switch statements become hard to maintain
- When implementing character states, enemy AI, or gameplay flow

## Structure
```
                +------------------+
                |      Client      |
                +---------+--------+
                          |
                          v
                +------------------+
                |     Context       |
                | - CurrentState    |
                | + SetState()      |
                +---------+--------+
                          |
                          v
                +------------------+
                |      State        |
                | + Enter()         |
                | + Exit()          |
                | + Update()        |
                +---------+--------+
                          |
            +-------------+-------------+
            |                           |
            v                           v
+---------------------+     +---------------------+
|   ConcreteStateA    |     |   ConcreteStateB    |
| + Enter()           |     | + Enter()           |
| + Update()          |     | + Update()          |
| + Exit()            |     | + Exit()            |
+---------------------+     +---------------------+
```

## Example
A Unity example where a PlayerController uses a StateMachine to switch between states such as Idle, Motion, Jump, and Attack.
Each state is represented as a separate class with its own input handling, update logic, and transitions.