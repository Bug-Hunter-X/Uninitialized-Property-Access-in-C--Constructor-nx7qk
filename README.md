# Uninitialized Property Access in C# Constructor

This repository demonstrates a common error in C#: accessing an uninitialized property within a class's constructor.  Uninitialized properties can lead to unexpected behavior or runtime exceptions.

## The Bug

The `bug.cs` file contains code that exemplifies this issue.  The `ExampleClass` attempts to access the `AnotherProperty` within the `MyMethod` before assigning it a value. This may return a default value (0 for integers, null for reference types), which could be unexpected.

## The Solution

The `bugSolution.cs` file presents a corrected version. The `AnotherProperty` is now initialized in the constructor, resolving the potential for undefined behavior.

## How to reproduce

1. Clone this repository.
2. Open `bug.cs` in a C# IDE (like Visual Studio).
3. Build and run the project. Observe the output (which might be 0).
4. Repeat for `bugSolution.cs` to see the corrected behavior.

## Lessons Learned

Always initialize properties within your constructor to avoid potential issues related to unexpected default values, especially if these properties are critical to your class's functionality. Proper initialization can prevent subtle bugs that might be difficult to track down later.