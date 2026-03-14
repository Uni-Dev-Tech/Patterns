# Command Pattern

## Purpose
Encapsulates a request as an object, thereby allowing parameterization of clients with queues, 
requests, and operations.  
Command lets you decouple the object that invokes an operation from the one that knows how to perform it.

## Benefits
- Encapsulates actions as objects
- Supports undo/redo functionality
- Promotes loose coupling between invoker and executor
- Makes it easy to extend new commands without modifying existing code

## When to Use
- When you need to issue requests to objects without knowing anything about the operation or the receiver
- When you want to support undo/redo operations
- When implementing macro commands or sequences of actions
- When you want to parameterize objects with operations

## Structure
```

	            +------------------+
                |      Client      |
                +---------+--------+
                          |
                          v
                +------------------+
                |      Invoker     |
                |  - command       |
                +---------+--------+
                          |
                          v
                  +---------------+
                  |    Command    |
                  |  (interface)  |
                  +-------+-------+
                          |
        +-----------------+-----------------+
        |                 |                 |
        v                 v                 v
+---------------+ +---------------+ +---------------+
| CommandA      | | CommandB      | | CommandC      |
+---------------+ +---------------+ +---------------+
                          |
                          v
                      +-------+
                      |Receiver|
                      +-------+

```

## Example
A simple example in Unity where a PlayerInput executes move commands (forward, backward, left, right) 
and a CommandContainer allows undoing the previous command.