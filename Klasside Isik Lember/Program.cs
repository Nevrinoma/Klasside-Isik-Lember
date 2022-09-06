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
StreamWriter to_file = new StreamWriter(@"..\..\..\file.txt", false);
foreach (Isik b in people)
{
    b.PrintInfo();
    Console.WriteLine("----------------------------------Person information--------------------------------");
    to_file.WriteLine(b.name + "," + b.calAge() + "," + b.sex + ";");
}
to_file.Close();
StreamReader from_file = new StreamReader(@"..\..\..\file.txt");
int lines= from_file.ReadToEnd().Split(new char[] { ';' } ).Count()-1;
Console.WriteLine(lines);

for (int i = 0; i < lines; i++)
{
    int rows = from_file.ReadLine().Split(new char [] { ',' }).Length;
    Console.WriteLine(rows);
}



from_file.Close();
//string text = from_file.ReadToEnd();
//Console.WriteLine(text);