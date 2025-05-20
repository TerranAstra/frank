# Frank._Frank._build
``` dotnet script Frank.Build.0010.MakeFilesAndFolders.csx ```

# Frank._build()
You cannot run a `.cs` (C# source) file directly in the same way you can run a `.ps1` (PowerShell) script. C# is a compiled language, so it normally requires compilation before execution. However, there are ways to get close to that experience:

### **C# Scripting with `dotnet-script`**
- You can install the [`dotnet-script`](https://github.com/filipw/dotnet-script) global tool, which allows you to run `.csx` (C# script) files directly from the command line.
- **Install:**  
  ```sh
  dotnet tool install -g dotnet-script
  ```
- **Run a script:**  
  ```sh
  dotnet script myscript.csx
  ```
- `.csx` files are like `.cs` files but allow top-level statements and scripting features.

---

### 2. **C# Interactive (`csi`)**
- The .NET SDK includes a C# interactive shell (`csi`), which can execute C# code interactively or from a file.
- **Run a file:**  
  ```sh
  csi myscript.csx
  ```
- Again, this works best with `.csx` script files, not standard `.cs` files.

---

### 3. **.NET Fiddle / LINQPad / Online Runners**
- For quick experiments, you can use online tools like [.NET Fiddle](https://dotnetfiddle.net/) or [LINQPad](https://www.linqpad.net/).





Auto-generated ReadMe for Frank._build.