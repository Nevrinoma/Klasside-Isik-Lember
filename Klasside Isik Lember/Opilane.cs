using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Klasside_Isik_Lember.Kutsekooliopilane;
using static Klasside_Isik_Lember.Tootaja;

namespace Klasside_Isik_Lember
{
    class Opilane : Isik
    {
        public string school;
        public string grade;
        public enum Grupp { strong, weak }
        public Grupp grupp;
        



        public void Change_School(string newSchool) { school = newSchool; }




        public Opilane(string name, int dateofbirth, Sex sex, Grupp grupp, string school, string grade) : base(name, dateofbirth, sex)
        {
            this.grupp = grupp;
            this.grade = grade;
            this.school = school;
        }

        public override double calSalary(double nonTaxRef, double Tax)
        {
            throw new NotImplementedException();
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"CLASS >>> Opilane\nNAME >>> {name}\nAGE_OF_BIRTH >>> {dateofbirth}\nAGE >>> {base.calAge()}\nGENDER >>> {sex}\nSchool >>> {school}\nGrade >>> {grade}\nGrupp >>> {grupp}");
        }
    }
}
