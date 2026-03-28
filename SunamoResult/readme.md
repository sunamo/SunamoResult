# SunamoResult

Result wrapper classes for converting methods with `ref`/`out` parameters to async-compatible patterns and more.

## Overview

SunamoResult provides lightweight result types that encapsulate either a successful value or an exception message, enabling clean error handling in async workflows where `ref`/`out` parameters are not supported.

## Key Classes

- **ResultWithException&lt;T&gt;** - Wraps either a result value of type `T` or an exception message string
- **ResultWithExceptionList&lt;T&gt;** - Collection of `ResultWithException<T>` with aggregate error checking via `HasAnyError`
- **MayExcHelper** - Helper for checking and logging exception messages
- **OutRef&lt;T, U&gt;** - Holds two values as an alternative to `ref`/`out` parameters
- **OutRef3&lt;T, U, V&gt;** - Holds three values as an alternative to `ref`/`out` parameters
- **OutRef4&lt;T, U, V, W&gt;** - Holds four values as an alternative to `ref`/`out` parameters

## Installation

```bash
dotnet add package SunamoResult
```

## Usage

```csharp
// Wrap a successful result
var success = new ResultWithException<string>("data");
success.Data = "actual data";

// Wrap an exception
var failure = new ResultWithException<string>(new InvalidOperationException("something failed"));
if (MayExcHelper.HasException(failure.ExceptionMessage))
{
    // Exception was logged to console
    return;
}

// Use OutRef for async methods that need multiple return values
var result = new OutRef<string, int>("value", 42);
Console.WriteLine(result.Item1); // "value"
Console.WriteLine(result.Item2); // 42
```

## Target Frameworks

`net10.0`, `net9.0`, `net8.0`

## License

MIT
