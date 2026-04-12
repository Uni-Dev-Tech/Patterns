# MVVM (Model-View-ViewModel)

## Type
Architectural Pattern (not part of GoF)

## Purpose
Separates application logic from UI by introducing a ViewModel that exposes data and state for the View.
MVVM allows the View to automatically update when the underlying data changes.

## Benefits
- Clear separation of concerns
- Supports reactive and data-driven UI
- Reduces direct interaction between UI and business logic
- Improves maintainability for complex UI systems

## When to Use
- When building complex UI systems (inventory, shop, settings)
- When UI depends heavily on changing state
- When you want reactive updates instead of manual UI refresh
- When working with data binding or observable properties

## Structure
```
                +------------------+
                |      View        |
                | (UI / Mono)      |
                +---------+--------+
                          |
                  (Bindings / Events)
                          |
                          v
                +------------------+
                |    ViewModel     |
                +---------+--------+
                          |
                          v
                +------------------+
                |      Model       |
                +------------------+
```

## Example
A Unity example where a CounterView binds to a CounterViewModel,
which updates a CounterModel.
The View reacts to changes in observable properties (e.g., CounterText),
allowing automatic UI updates without direct calls from the logic layer.