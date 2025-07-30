# C# Object Lifetime — Learning Repository

This repository explores key C# concepts related to object lifetime, including proper resource management, garbage collection, destructors, indexers, and lazy initialization.

## Topics Covered

- **Garbage Collection (GC)**  
  Demonstrates how the .NET GC works and when finalizers are triggered.

- **Destructors & Finalizers**
  - Shows usage of `~ClassName()` destructors.
  - Example: `GCDestructor.cs`

- **IDisposable Pattern**
  - Implementation of proper resource disposal using `IDisposable`.
  - Example: `FileLogger.cs`

- **Lazy Initialization**
  - Uses `Lazy<T>` to defer object creation until needed.
  - Example: `NumberList.cs`

- **Indexers**
  - Custom accessors using `this[int index]`.
  - Example: `Student.cs`

## Project Structure

- `ConsoleApp1/`
  - `Program.cs`: Entry point with usage examples for each class.
  - `GCDestructor.cs`: Demonstrates garbage collection behavior.
  - `FileLogger.cs`: Implements `IDisposable` with a file-based logger.
  - `NumberList.cs`: Shows lazy loading with `Lazy<T>`.
  - `Student.cs`: Demonstrates indexers to manage a fixed module list.

## How to Run

1. Open the solution `ConsoleApp1.sln` in Visual Studio.
2. Build the project.
3. Run the console app to observe output from each object lifecycle scenario.

## Purpose

This project is intended as a teaching aid or self-study resource for understanding how C# manages object memory, finalization, and cleanup patterns.
