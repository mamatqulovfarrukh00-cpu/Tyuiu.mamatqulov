using System.Collections.Generic;
using Tyuiu.mamatqulov.Sprint_2.Task2;

namespace Tyuiu.mamatqulov.Sprint_2.Task3
{
    public interface IReportable { string GenerateReport(); }
    public interface ITeamLeader { List<string> GetTeamMembers(); }

    public class ProjectManager : Manager, IReportable, ITeamLeader
    {
        public string ProjectName { get; set; }
        private List<string> teamMembers = new List<string>();

        public ProjectManager(string name, string position, double salary, string department, string projectName) 
            : base(name, position, salary, department) 
        { 
            ProjectName = projectName; 
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Проект: {ProjectName}");
        }

        public string GenerateReport() => $"Отчет по проекту '{ProjectName}': выполнено 85% задач.";
        
        public List<string> GetTeamMembers()
        {
            teamMembers.Add("Али Маматкулов");
            teamMembers.Add("Фаррух Рустамов");
            return teamMembers;
        }
    }
}