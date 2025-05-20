using System;
using System.IO;

// Root directory
var root = @"C:\git\frank";

// Get all top-level directories in root
var dirs = Directory.GetDirectories(root);

foreach (var dir in dirs)
{
    var name = Path.GetFileName(dir);
    if (string.IsNullOrWhiteSpace(name)) continue;
    // Standard subfolders/files
    var chatsDir = Path.Combine(dir, $"{name}.Chats");
    var fangshiDir = Path.Combine(dir, $"{name}.Fangshi");
    var build = Path.Combine(dir, $"{name}.Build.csx");
    var readme = Path.Combine(dir, $"{name}.ReadMe.md");

    // Create Chats folder
    if (!Directory.Exists(chatsDir))
    {
        Directory.CreateDirectory(chatsDir);
        Console.WriteLine($"Created: {chatsDir}");
    }

    // Create Fangshi folder
    if (!Directory.Exists(fangshiDir))
    {
        Directory.CreateDirectory(fangshiDir);
        Console.WriteLine($"Created: {fangshiDir}");
    }

    // Create Build.csx
    if (!File.Exists(build))
    {
        File.WriteAllText(build, $"// {name}.Build.csx\n// Auto-generated build script for {name}.");
        Console.WriteLine($"Created: {build}");
    }

    // Create ReadMe.md
    if (!File.Exists(readme))
    {
        File.WriteAllText(readme, $"# {name}\n\nAuto-generated ReadMe for {name}.");
        Console.WriteLine($"Created: {readme}");
    }

}

Console.WriteLine("Done.");

