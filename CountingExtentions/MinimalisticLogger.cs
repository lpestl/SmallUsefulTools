// Created by Michael S. Kataev, lpestlname@gmail.com
// Copyright © 2023 Michael S. Kataev. All rights reserved.

namespace SmallUsefullTools {
    public class MinimalisticLogger 
    {
        private string _logDirPath;
        private string _currentLogFileName;

        public MinimalisticLogger() 
        {
            // By default, we place the folder with logs next to the executable file
            _logDirPath = Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "logs");
            if (!Directory.Exists(_logDirPath))
                Directory.CreateDirectory(_logDirPath);

            // I assign the log name as the launch date and time
            var now = DateTime.Now;
            _currentLogFileName = $"{now.Year}-{now.Month}-{now.Day}_{now.Hour}-{now.Minute}-{now.Second}.log";
            
            Log($"--- Logger started at {DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss'.'ms")} ---");
        }

        ~MinimalisticLogger() 
        {
            Log($"--- Logger finished at {DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss'.'ms")} ---");
        }

        public void Log(string msg)
        {
            PrintLine(msg, "INFO");
        }

        public void Warning(string msg) 
        {
            PrintLine(msg, "WARNING");
        }

        public void Error(string msg) 
        {
            PrintLine(msg, "ERROR");
        }

        private void PrintLine(string msg, string type)
        {
            var line = $"[{type}][{DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss'.'ms")}] {msg}";
            using (var tw = new StreamWriter(Path.Combine(_logDirPath, _currentLogFileName), true)) 
            {
                tw.WriteLine(line);
            }
            Console.WriteLine(msg);
        }
    }
}