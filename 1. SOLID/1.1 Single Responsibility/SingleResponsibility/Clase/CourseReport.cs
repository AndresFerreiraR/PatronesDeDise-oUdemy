
namespace SingleResponsibility.Clase
{
    using SingleResponsibility.Modelo;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Finalidad de la clase crear un registro de CourseReportEntry
    /// </summary>
    public class CourseReport
    {
        private readonly List<CourseReportEntry> _entries;

        public CourseReport()
        {
            _entries = new List<CourseReportEntry>();
        }

        public void AddEntry(CourseReportEntry entry) => _entries.Add(entry);

        public void RemoveEntryAt(int index) => _entries.RemoveAt(index);

        /// Para cumplir con el principio de responsabilidad unica debemos crear la clase 
        /// que se encargue de guardar el archivo plano con los nombres, esta no debe estar
        /// incluida en la clase que persiste la información.

        //public void SaveToFile(string directoryPath, string fileName)
        //{
        //    if (!Directory.Exists(directoryPath))
        //    {
        //        Directory.CreateDirectory(directoryPath);
        //    }

        //    File.WriteAllText(Path.Combine(directoryPath, fileName), ToString());
        //}
        public override string ToString() =>
            string.Join(Environment.NewLine, _entries.Select(x => $"Curso: {x.Name}, Estudiantes: {x.Students}, Valoración: {x.Rating}"));
    }
}
