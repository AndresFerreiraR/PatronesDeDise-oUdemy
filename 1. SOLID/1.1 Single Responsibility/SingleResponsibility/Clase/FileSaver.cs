﻿
namespace SingleResponsibility.Clase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class FileSaver
    {
        public void SaveToFile(string directoryPath, string fileName, CourseReport report)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), report.ToString());
        }
    }
}
