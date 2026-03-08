# Singleton Pattern

## Purpose
Ensures a class has only one instance and provides a global point of access to it.
Singleton allows shared systems to be accessed from anywhere in the application.

## Benefits
- Guarantees a single instance of a class
- Provides global access to shared systems
- Simplifies access to core managers
- Ensures a single source of truth for global state

## When to Use
- When exactly one instance of a class should exist.
- When multiple objects need access to the same shared resource.
- When managing global systems like GameManager, AudioManager, or Configs.

## Structure
```

	            +------------------+
                |      Client      |
                +---------+--------+
                          |
                          v
                +------------------+
                |     Singleton     |
                |   - Instance      |
                +---------+--------+
                          |
                          v
                +------------------+
                |   GameManager     |
                +------------------+

```

## Example
A basic Unity implementation where a GameManager tracks the player's score, 
while GameConfigs provides configurable scoring values accessible through singleton instances.