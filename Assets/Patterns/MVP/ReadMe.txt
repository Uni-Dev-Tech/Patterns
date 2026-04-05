# MVP (Model-View-Presenter)

## Type
Architectural Pattern (not part of GoF)

## Purpose
Separates application logic from UI by introducing a Presenter that handles all communication between Model and View.
MVP ensures that the View remains passive and contains no business logic.

## Benefits
- Clear separation of responsibilities
- View becomes simple and reusable
- Better testability (Presenter can be tested without Unity)
- Decouples UI from business logic

## When to Use
- When building UI systems (HUD, menus, panels)
- When UI should not contain logic
- When multiple views depend on the same data
- When you want a clean and testable architecture

## Structure
```
                +------------------+
                |      View        |
                | (UI / Mono)      |
                +---------+--------+
                          |
                    (Input Events)
                          |
                          v
                +------------------+
                |    Presenter     |
                +---------+--------+
                          |
                          v
                +------------------+
                |      Model       |
                +---------+--------+
                          |
                    (Data / Events)
                          |
                          v
                +------------------+
                |      View        |
                +------------------+
```

## Example
A Unity example where a CounterView sends button click events (increase/decrease) to a CounterPresenter,
which updates the CounterModel.
The Presenter then updates the View, ensuring that the UI contains no logic and only reflects the state.