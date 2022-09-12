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




List<Tootaja> tootajad = new List<Tootaja>();
List<Opilane> opilased = new List<Opilane>();
List<Kutsekooliopilane> kutsekooliopilased = new List<Kutsekooliopilane>();
List<Isik> people = new List<Isik>();
people.Add(bob);
people.Add(bib);
people.Add(beb);

StreamWriter to_file = new StreamWriter(@"..\..\..\file.txt", false);
foreach (Isik p in people)
{
    p.PrintInfo();
    Console.WriteLine();
    
    to_file.WriteLine(p.GetType().Name + "," + p.name + "," + p.calAge() + "," + p.sex + "," + p.GetType().GetEnumValues + "," + p.workPlace + p.calSalary(500.0, 20.0) + ";");
}
to_file.Close();

var fromfile = File.ReadAllLines(@"..\..\..\file.txt");
StreamReader from_file = new StreamReader(@"..\..\..\file.txt");


for (int i = 0; i < people.Count; i++)
{

    string[] row_count = fromfile[i].Split(',');
    
    Console.WriteLine("class - " + row_count[0] +"\n name - " + row_count[1] + "\n age - " + row_count[2] + "\n gender - " + row_count[3] + "\n post - " + row_count[4] + "\n workplace - " + "\n salary - " + row_count[5].Split(';')[0]);

}

//for (int i = 0; i < people.count; i++)
//{

//    string[] row_count = fromfile[i].split(',');
//    if (row_count[0] =="tootaja")
//    {
//        tootaja (row_count[1]) = new tootaja(row_count[1],)
//        tootajad.add(row_count[1]);
//    }

//}






from_file.Close();