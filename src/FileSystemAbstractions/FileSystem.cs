using System.Collections.Generic;
using System.IO;
using System.Text;

namespace System.IO.FileSystemAbstractions;

public class FileSystem : IFileSystem
{
    public bool Exists(string path)
        => File.Exists(path);

    public FileStream Create(string path)
        => File.Create(path);
    public FileStream Create(string path, int bufferSize)
        => File.Create(path, bufferSize);
    public FileStream Create(string path, int bufferSize, FileOptions fileOptions)
        => File.Create(path, bufferSize, fileOptions);

    public StreamWriter CreateText(string path)
        => File.CreateText(path);
    public void Copy(string sourceFileName, string destinationFileName)
        => File.Copy(sourceFileName, destinationFileName);
    public void Copy(string sourceFileName, string destinationFileName, bool overwrite)
        => File.Copy(sourceFileName, destinationFileName, overwrite);


    public StreamWriter AppendText(string path)
        => File.AppendText(path);


    public void AppendAllText(string path, string contents)
        => File.AppendAllText(path, contents);
    public void AppendAllText(string path, string contents, Encoding encoding)
        => File.AppendAllText(path, contents, encoding);


    public void AppendAllLines(string path, IEnumerable<string> contents)
        => File.AppendAllLines(path, contents);
    public void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding)
        => File.AppendAllLines(path, contents, encoding);


    public void Delete(string path)
        => File.Delete(path);

    public void WriteAllText(string path, string contents)
        => File.WriteAllText(path, contents);
    public void WriteAllText(string path, string contents, Encoding encoding)
        => File.WriteAllText(path, contents, encoding);

    public void WriteAllBytes(string path, byte[] bytes)
        => File.WriteAllBytes(path, bytes);

    public void Move(string sourceFileName, string destinationFileName)
        => File.Move(sourceFileName, destinationFileName);

    public string ReadAllText(string path)
        => File.ReadAllText(path);

}
