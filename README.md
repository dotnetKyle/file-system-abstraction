# file-system-abstraction

A C# file system abstraction for IoC against the file system, helpful for unit testing.  You can build mock file systems by using the IFileSystem interface or IDirectories interface.


Add to Dependency Injection:

```csharp
builder.Services.AddSingleton<IFileSystem, FileSystem>();

builder.Services.AddSingleton<IDirectories, Directories>();
```