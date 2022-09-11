# file-system-abstraction

A C# file system abstraction for inversion of control against the file system.  You can build mock file systems by using the IFileSystem interface.


Add to Dependency Injection:

```csharp
builder.Services.AddSingleton<IFileSystem, FileSystem>();

builder.Services.AddSingleton<IDirectories, Directories>();
```