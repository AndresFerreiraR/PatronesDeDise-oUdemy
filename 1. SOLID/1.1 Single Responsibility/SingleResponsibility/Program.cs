// See https://aka.ms/new-console-template for more information
//.WriteLine("Hello, World!");

using SingleResponsibility.Clase;
using SingleResponsibility.Modelo;

var report = new CourseReport();
report.AddEntry(new CourseReportEntry { Name = "Patrones de diseño", Students = 1000, Rating = 5 });
report.AddEntry(new CourseReportEntry { Name = "Flutter", Students = 1900, Rating = 4.5 });

Console.WriteLine(report.ToString());

var fileReport = new FileSaver();
fileReport.SaveToFile(@"Reports", "WorkReport.txt", report);