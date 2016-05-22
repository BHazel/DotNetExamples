C# 6 Demos
==========

This repository contains a basic demo of the new language features in C# 6 and a comparison with C# 5.
Features covered include:

* `AutoProperties.cs`: Auto-properties
* `CatchAwait.cs`: `await` in `catch` and `finally` blocks
* `DictionaryInitialisers.cs`: Dictionary initialisers
* `ExceptionFilters.cs`: Exception filters
* `ExpressionsAndStructs.cs`: Lambda expressons for class members and new `struct` features
* `NameOf.cs`: `nameof` keyword
* `NullConditional.cs`: null-conditional `?.` operator
* `StringInterpolation.cs`: string interpolation
* `UsingStatic.cs`: `using static` keywords for importing static classes

Examples for C# 5 and C# 6 are found in the `CS5` and `CS6` directories respectively.

Running the Demos
-----------------

**To run the demos you need Visual Studio 2015 installed as the "Roslyn" compilers in Visual Studio 2013
do not support all new features.**

All demos are run as a single executable controlled by settings in `app.config`.

* You can control the versions of C# code to run by setting the `RunDemosCSharp{Version}` settings to `true`.
* Individual demos can be run by setting their values to `true`; their setting name are the same as their
demo filename.
* Any settings taking the form `Demo{DemoName}{Setting}` are used by specific demos to control their operation.
