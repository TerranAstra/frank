#r "System.IO"
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
    var basePath = Path.Combine(root, dir);
    // Standard subfolders/files
    var chatsDir = Path.Combine(dir, $"Frank._{name}.Chats");
    var readme = Path.Combine(dir, $"Frank._{name}.ReadMe.md");
    var build = Path.Combine(dir, $"Frank._{name}.Build.csx");
    var fangshiDir = Path.Combine(dir, $"Frank._{name}.Fangshi");

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
    // Create ReadMe.md
    if (!File.Exists(readme))
    {
        File.WriteAllText(readme, $"# Frank._{name}\n\nAuto-generated ReadMe for {name}.");
        Console.WriteLine($"Created: {readme}");
    }
    // Create Build.csx
    if (!File.Exists(build))
    {
        File.WriteAllText(build, $"// Frank._{name}.Build.csx\n// Auto-generated build script for {name}.");
        Console.WriteLine($"Created: {build}");
    }
}

Console.WriteLine("Done."); 