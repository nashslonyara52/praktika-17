using System;
[Flags]
public enum FileAccess
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4
}
public struct File
{
    public FileAccess Permissions { get; set; }

    public bool CanRead()
    {
        return Permissions.HasFlag(FileAccess.Read);
    }

    public bool CanWrite()
    {
        return Permissions.HasFlag(FileAccess.Write);
    }
    public bool CanExecute()
    {
        return Permissions.HasFlag(FileAccess.Execute);
    }
}
class Program
{
    static void Main()
    {
        var f = new File { Permissions = FileAccess.Read | FileAccess.Write };
        Console.WriteLine(f.CanRead());
        Console.WriteLine(f.CanWrite());
    }
}