# Composite Pattern

## Purpose
Composes objects into tree structures to represent part-whole hierarchies.
Composite lets clients treat individual objects and compositions of objects uniformly.

## Benefits
- Simplifies client code (works with single objects and groups the same way)
- Supports hierarchical structures
- Makes it easy to add new component types
- Follows Open/Closed Principle

## When to Use
- When objects form a tree-like structure
- When you want to treat individual and grouped objects the same way
- When working with recursive hierarchies (e.g., UI, units, file systems)

## Structure
```  
                +------------------+
                |      Client      |
                +---------+--------+
                          |
                          v
                +------------------+
                |     Component     |
                | + Operation()     |
                +---------+--------+
                          |
            +-------------+-------------+
            |                           |
            v                           v
     +-----------+               +------------------+
     |   Leaf    |               |    Composite     |
     | + Operation()             | + Add()          |
     +-----------+               | + Remove()       |
                                 | + Operation()   |
                                 +--------+--------+
                                          |
                                          v
                                 +------------------+
                                 |    Component     |
                                 +------------------+
```

## Example
A Unity example where Soldier is a leaf implementing IUnit,
and Squad and Army are composites that contain multiple IUnit objects.
Commands like Attack, Defence, and Retreat are propagated through the hierarchy,
allowing both individual units and groups to be controlled in the same way.