using WebDevelopment;
using DesktopApplications;
using MobileApplications;
using CloudComputing;
using DataScience;
using ArtificialIntelligence;
using DevOps;
using Security;
using IoT;
using GameDevelopment;
using EmbeddedSystems;
using EnterpriseSolutions;
using DatabaseSolutions;
using Networking;
using Blockchain;

Console.WriteLine("=== Software Solution Domains Demo ===\n");

// Create instances of all domain classes
var domains = new List<(string Name, Func<string> Describe)>
{
    ("Web Development", () => new WebDevelopmentDomain().Describe()),
    ("Desktop Applications", () => new DesktopApplicationsDomain().Describe()),
    ("Mobile Applications", () => new MobileApplicationsDomain().Describe()),
    ("Cloud Computing", () => new CloudComputingDomain().Describe()),
    ("Data Science", () => new DataScienceDomain().Describe()),
    ("Artificial Intelligence", () => new ArtificialIntelligenceDomain().Describe()),
    ("DevOps", () => new DevOpsDomain().Describe()),
    ("Security", () => new SecurityDomain().Describe()),
    ("Internet of Things (IoT)", () => new IoTDomain().Describe()),
    ("Game Development", () => new GameDevelopmentDomain().Describe()),
    ("Embedded Systems", () => new EmbeddedSystemsDomain().Describe()),
    ("Enterprise Solutions", () => new EnterpriseSolutionsDomain().Describe()),
    ("Database Solutions", () => new DatabaseSolutionsDomain().Describe()),
    ("Networking", () => new NetworkingDomain().Describe()),
    ("Blockchain", () => new BlockchainDomain().Describe())
};

// Display all domains
int counter = 1;
foreach (var (name, describe) in domains)
{
    Console.WriteLine($"{counter}. {name}");
    Console.WriteLine($"   {describe()}\n");
    counter++;
}

Console.WriteLine($"Total domains showcased: {domains.Count}");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
