using Klasside_Isik_Lember;

Console.WriteLine("----------------------------------Person information--------------------------------");
Tootaja bob = new Tootaja("Bob", 2007, Isik.Sex.Male, Tootaja.Post.Clerk, "Microsoft", 989.50);
bob.calSalary(500.0,20.0);
bob.calAge();
//bob.PrintInfo();
Opilane bib = new Opilane("Bib", 1998, Isik.Sex.Female, Opilane.Grupp.strong, "School of Bibo", "STARpv21");
bib.calAge();
//bib.PrintInfo();
Kutsekooliopilane beb = new Kutsekooliopilane("Beb", 1993, Isik.Sex.Male, Kutsekooliopilane.Specialization.Mathematician,Kutsekooliopilane.Family.Small, "University of Bebra", 3);
beb.PrintInfo();