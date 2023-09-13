# CountingExtentions

Console CLI tool for counting the number of files with different extensions and a general list of extensions in the folder, the path to which is passed as a parameter.

## Requirements

* [.NET SDK 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
* [VS Code](https://code.visualstudio.com/download)

## How to build

To build the tool, we just need to have access to .NET 7 from the command line. First, go to the `CountingExtentions` directory and make sure that the `dotnet` command is available and has the correct version.

```bash
G:\Tools\SmallUsefulTools>cd CountingExtentions

G:\Tools\SmallUsefulTools\CountingExtentions>dotnet --list-sdks
7.0.400 [C:\Program Files\dotnet\sdk]
```

In order to assemble the project, just enter:

```bash
dotnet build CountingExtentions.csproj
```

It is also possible to run the project directly using `dotnet`:

```bash
dotnet run CountingExtentions.csproj
```

The executable file itself is placed along the path after assembly `CountingExtentions\bin\Debug\net7.0\` or `CountingExtentions\bin\Release\net7.0\`.


You can also open the project, build and run using **VS Code** IDE:
* open **VS Code**;
* open `SmallUsefulTools.code-workspace` using menu `File -> Open workspace from File...`;
* go to the `Run and Debug` tab;
* select from the drop-down list `Launch "CountingExtentions" .NET Core`;
* see a result.

## How to use

After building the application, you have an executable file `CountingExtentions.exe`. You can run it:
* from any working directory without parameters, then the scanning will be carried out exactly in the working directory.
    Example:
```bash
G:\Tools\SmallUsefulTools>CountingExtentions\bin\Debug\net7.0\CountingExtentions.exe      
--- Logger started at 2023-09-13 23:38:28.3828 ---
Path: "G:\Tools\SmallUsefulTools";
All files: 99;
+-----------------------+
|       Extentions (20) |
+-----------------------+
|       .gitignore (1)  |
|       .md (2)         |
|       .code-workspace (1)     |
|       .json (6)       |
|       .csproj (1)     |
|       .cs (5)         |
|       .sample (14)    |
|       .props (1)      |
|       .targets (1)    |
|       .cache (5)      |
|       .idx (1)        |
|       .pack (1)       |
|       .rev (1)        |
|       .dll (4)        |
|       .exe (2)        |
|       .pdb (2)        |
|       .txt (1)        |
|       .editorconfig (1)       |
|       .log (7)        |
+-----------------------+

G:\Tools\SmallUsefulTools>
```

* can run `CountingExtentions.exe`, passing as the first parameter the path to the directory that needs to be scanned.
Example: 
```bash
G:\Tools\SmallUsefulTools\CountingExtentions\bin\Debug\net7.0>CountingExtentions.exe "g:\\Tools\\SmallUsefulTools\\" 
--- Logger started at 2023-09-13 23:36:26.3626 ---
Path: "g:\\Tools\\SmallUsefulTools\";
All files: 98;
+-----------------------+
|       Extentions (20) |
+-----------------------+
|       .gitignore (1)  |
|       .md (2)         |
|       .code-workspace (1)     |
|       .json (6)       |
|       .csproj (1)     |
|       .cs (5)         |
|       .sample (14)    |
|       .props (1)      |
|       .targets (1)    |
|       .cache (5)      |
|       .idx (1)        |
|       .pack (1)       |
|       .rev (1)        |
|       .dll (4)        |
|       .exe (2)        |
|       .pdb (2)        |
|       .txt (1)        |
|       .editorconfig (1)       |
|       .log (6)        |
+-----------------------+

G:\Tools\SmallUsefulTools\CountingExtentions\bin\Debug\net7.0>
```
