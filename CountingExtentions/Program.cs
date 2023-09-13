// Created by Michael S. Kataev, lpestlname@gmail.com
// Copyright © 2023 Michael S. Kataev. All rights reserved.

using SmallUsefullTools;

string[] arguments = Environment.GetCommandLineArgs();

// To analyze the number of files with different extensions, 
// we need the path to the folder, which we will store in the "path" variable
string path;

{
    // By default, we will take the path to the current launch folder
    path = Directory.GetCurrentDirectory();
}

// Let's check if the application has launch arguments
if (arguments.Any())
{
    foreach (var arg in arguments)
    {
        // We expect the first argument to be the path to the folder to be scanned
        if (Directory.Exists(arg))
        {
            // And if the path exists, save it
            path = arg;
            break;
        }
    }
}

var logger = new MinimalisticLogger();

// Find all files in all subfolders
var currentDir = new DirectoryInfo(path);
var files = currentDir.GetFiles("*", SearchOption.AllDirectories);

logger.Log($"Path: \"{path}\";");
logger.Log($"All files: {files.Count()};");

// Let's count the number of files of each extention
Dictionary<string, int> extentionsDict = new Dictionary<string, int>();
foreach (var file in files) 
{
    var key = file.Extension.ToLower();
    if (!extentionsDict.ContainsKey(key)) 
        extentionsDict.Add(key, 0);
    extentionsDict[key]++;
}

// And we will display this information
logger.Log($"+-----------------------+");
logger.Log($"|\tExtentions ({extentionsDict.Count}) |");
logger.Log($"+-----------------------+");
foreach (var extPair in extentionsDict)
{
    logger.Log($"|\t{extPair.Key} ({extPair.Value})\t|");
}
logger.Log($"+-----------------------+");