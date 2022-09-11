﻿using System;
using System.Collections.Generic;
using System.IO;

namespace System.IO.FileSystemAbstractions;

partial class Directories : IDirectories
{
    public DirectoryInfo CreateDirectory(string path)
         => Directory.CreateDirectory(path);
    public void Delete(string path)
         => Directory.Delete(path);
    public void Delete(string path, bool recursive)
         => Directory.Delete(path, recursive);
    public IEnumerable<string> EnumerateDirectories(string path)
         => Directory.EnumerateDirectories(path);
    public IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
         => Directory.EnumerateDirectories(path, searchPattern);
    public IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
         => Directory.EnumerateDirectories(path, searchPattern, searchOption);
    public IEnumerable<string> EnumerateFiles(string path)
         => Directory.EnumerateFiles(path);
    public IEnumerable<string> EnumerateFiles(string path, string searchPattern)
         => Directory.EnumerateFiles(path, searchPattern);
    public IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
         => Directory.EnumerateFiles(path, searchPattern, searchOption);
    public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
         => Directory.EnumerateFileSystemEntries(path, searchPattern, searchOption);
    public IEnumerable<string> EnumerateFileSystemEntries(string path)
         => Directory.EnumerateFileSystemEntries(path);
    public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
         => Directory.EnumerateFileSystemEntries(path, searchPattern);
    public bool Exists(string path)
         => Directory.Exists(path);
    public DateTime GetCreationTime(string path)
         => Directory.GetCreationTime(path);
    public DateTime GetCreationTimeUtc(string path)
         => Directory.GetCreationTimeUtc(path);
    public string GetCurrentDirectory()
         => Directory.GetCurrentDirectory();
    public string[] GetDirectories(string path, string searchPattern)
         => Directory.GetDirectories(path, searchPattern);
    public string[] GetDirectories(string path)
         => Directory.GetDirectories(path);
    public string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
         => Directory.GetDirectories(path, searchPattern, searchOption);
    public string GetDirectoryRoot(string path)
         => Directory.GetDirectoryRoot(path);
    public string[] GetFiles(string path)
         => Directory.GetFiles(path);
    public string[] GetFiles(string path, string searchPattern)
         => Directory.GetFiles(path, searchPattern);
    public string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
         => Directory.GetFiles(path, searchPattern, searchOption);
    public string[] GetFileSystemEntries(string path)
         => Directory.GetFileSystemEntries(path);
    public string[] GetFileSystemEntries(string path, string searchPattern)
         => Directory.GetFileSystemEntries(path, searchPattern);
    public string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
         => Directory.GetFileSystemEntries(path, searchPattern, searchOption);
    public DateTime GetLastAccessTime(string path)
         => Directory.GetLastAccessTime(path);
    public DateTime GetLastAccessTimeUtc(string path)
         => Directory.GetLastAccessTimeUtc(path);
    public DateTime GetLastWriteTime(string path)
         => Directory.GetLastWriteTime(path);
    public DateTime GetLastWriteTimeUtc(string path)
         => Directory.GetLastWriteTimeUtc(path);
    public string[] GetLogicalDrives()
         => Directory.GetLogicalDrives();
    public DirectoryInfo GetParent(string path)
         => Directory.GetParent(path);
    public void Move(string sourceDirName, string destDirName)
         => Directory.Move(sourceDirName, destDirName);
    public void SetCreationTime(string path, DateTime creationTime)
         => Directory.SetCreationTime(path, creationTime);
    public void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
         => Directory.SetCreationTimeUtc(path, creationTimeUtc);
    public void SetCurrentDirectory(string path)
         => Directory.SetCurrentDirectory(path);
    public void SetLastAccessTime(string path, DateTime lastAccessTime)
         => Directory.SetLastAccessTime(path, lastAccessTime);
    public void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
         => Directory.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
    public void SetLastWriteTime(string path, DateTime lastWriteTime)
         => Directory.SetLastWriteTime(path, lastWriteTime);
    public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
         => Directory.SetLastWriteTimeUtc(path, lastWriteTimeUtc);

    public string GetEnvironmentFolderPath(Environment.SpecialFolder folder)
    => Environment.GetFolderPath(folder);
    public string GetEnvironmentFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option)
        => Environment.GetFolderPath(folder, option);

}
