using Klasside_Isik_Lember;
using Microsoft.VisualBasic;
using System;
using static System.Formats.Asn1.AsnWriter;


Console.WriteLine("----------------------------------Person information--------------------------------");
Tootaja bob = new Tootaja("Bob", 2007, Isik.Sex.Male, Tootaja.Post.Clerk, "Microsoft", 989.50);
bob.calSalary(500.0,20.0);
bob.calAge();
//bob.PrintInfo();
Opilane bib = new Opilane("Bib", 1998, Isik.Sex.Female, Opilane.Grupp.strong, "School of Bibo", "STARpv21");
bib.calAge();
//bib.PrintInfo();
Kutsekooliopilane beb = new Kutsekooliopilane("Beb", 1993, Isik.Sex.Male, Kutsekooliopilane.Specialization.Mathematician,Kutsekooliopilane.Family.Small, "University of Bebra", 3);
//beb.PrintInfo();

List<Isik> people = new List<Isik>();
people.Add(bob);
people.Add(bib);
people.Add(beb);

StreamWriter to_file = new StreamWriter(@"......\file.txt", false);
foreach (Isik p in people)
{
    p.PrintInfo();
    to_file.WriteLine(p.name + "," + p.calAge() + "," + p.sex + ";");
}
to_file.Close();
var fromfile = File.ReadAllLines(@"......\file.txt");
StreamReader from_file = new StreamReader(@"......\file.txt");
int line_count = from_file.ReadToEnd().Split(new char[] { ';' }).Length - 1;
Console.WriteLine(line_count);
for (int i = 0; i < people.Count; i++)
{
    string[] row_count = fromfile[i].Split(',');
    Console.WriteLine("1 - " + row_count[0] + " 2 - " + row_count[1] + " 3 - " + row_count[2].Split(';')[0]);
}
from_file.Close();