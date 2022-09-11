using System.Collections.Generic;
using System.IO;
using System.Text;

namespace System.IO.FileSystemAbstractions;

public interface IFileSystem
{
    void AppendAllLines(string path, IEnumerable<string> contents);
    void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding);
    void AppendAllText(string path, string contents);
    void AppendAllText(string path, string contents, Encoding encoding);
    StreamWriter AppendText(string path);
    void Copy(string sourceFileName, string destinationFileName);
    void Copy(string sourceFileName, string destinationFileName, bool overwrite);
    FileStream Create(string path);
    FileStream Create(string path, int bufferSize);
    FileStream Create(string path, int bufferSize, FileOptions fileOptions);
    StreamWriter CreateText(string path);
    void Delete(string path);
    void Move(string sourceFileName, string destinationFileName);
    string ReadAllText(string path);
    void WriteAllBytes(string path, byte[] bytes);
    void WriteAllText(string path, string contents);
    void WriteAllText(string path, string contents, Encoding encoding);
}