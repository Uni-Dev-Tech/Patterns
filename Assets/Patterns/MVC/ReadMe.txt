# MVC (Model-View-Controller)

## Type
Architectural Pattern (not part of GoF)

## Purpose
Separates application into three main components — Model, View, and Controller —
to isolate business logic from presentation and input handling.

## Benefits
- Clear separation of concerns
- Easier maintenance and scaling
- Independent development of UI and logic
- Better testability

## When to Use
- When you want clean separation between logic and presentation
- When UI changes frequently
- When multiple views depend on the same data
- In medium/large scalable systems

## Structure
```
        +-------------+
        |   Input     |
        +------+------+ 
               |
               v
        +-------------+
        | Controller  |
        +------+------+ 
               |
               v
        +-------------+
        |    Model    |
        +------+------+ 
               |
        (Events/State)
               |
               v
        +-------------+
        |    View     |
        +-------------+
```

## Components
## Model
- Stores data and business logic
- Does not depend on View or Controller
- Notifies about changes via events

## View
- Responsible for visual representation
- Subscribes to Model events
- Does not modify Model directly

## Controller
- Handles input and user actions
- Creates Model and View
- Updates Model

## Example (Unity)

In this implementation:
- EnemyModel — handles health logic
- EnemyController — initializes model and views, processes input
Views:
- ParticlesEnemyView
- HighlightingEnemyView
- AnimationEnemyView

Each View reacts independently to Model events, allowing modular visual behavior.

## Notes (Unity Specific)
- Controller is implemented as MonoBehaviour
- Views are lightweight classes (not MonoBehaviour)
- Model is pure C# class (no Unity dependencies)
- Inspector is used for dependency injection

## Pros
- Decoupled architecture
- Flexible UI system (multiple views per model)
- Easy to extend (add new views without changing model)

## Cons
- More boilerplate
- Controller can become overloaded
- Requires discipline to maintain separation