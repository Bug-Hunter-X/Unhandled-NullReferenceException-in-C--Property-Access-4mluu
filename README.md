# Unhandled NullReferenceException in C# Property Access

This repository demonstrates a common C# error: a `NullReferenceException` arising from accessing an uninitialized property.  The `bug.cs` file contains the faulty code, while `bugSolution.cs` provides the corrected version.

**Problem:** The `MyProperty` is not initialized before being accessed in `MyMethod()`. This leads to a `NullReferenceException` at runtime.

**Solution:** Initialize `MyProperty` either in the constructor or before accessing it in the method.