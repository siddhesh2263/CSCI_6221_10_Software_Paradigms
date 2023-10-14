# CSCI_6221_10_Software_Paradigms
Homework and notes for the Advanced Software Paradigms Course

# 10/13/23

* Link for exception handling notes: https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/exception-handling/exception-types
* Link for event handling notes: https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/members/events
* Link for notes on functional programming: https://learn.microsoft.com/en-us/dotnet/fsharp/tutorials/functional-programming-concepts

---

## Notes on F#:
# Notes based on (https://www.youtube.com/watch?v=SvOInBxPL30) video:
* Functional programming is a process of building software by composing pure functions, avoiding shared state, mutable data, and side-effects.
* State - all remembered information in the sytem - variables etc.
* Why to avoid shared state? - when multple systems have access to same state, it becomes non deterministic; makes things less testable; also, it is not optimal for concurrent programs - trying to access same variable - can cause issues.
* Compose pure functions - a pure function by definition returns the same output for a given input - it is determnistic, and it has no side effctes, nothig else in the system will change; mapping one to one between input and output - always the same, nothing else will change in the system.
* F sharp is a function first language, it supports imperative, OOP, but by default it supports functional programming.
(But in the video, the main focus will be on functions.)
* We will actively seek decoupling of data and behavior; in OOP, data is encapsulated; but in functional, it is separated; one of the key shifts;

---
