using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasside_Isik_Lember
{
    class Kutsekooliopilane : Isik
    {
        public string institution;
        public enum Specialization { SoftwareDeveloper, Roboticist, Mathematician }
        public Specialization specialization;
        public int yearofstudy;
        public double scholarship;
        public int vsego;
        public enum Family { Large, Small }
        public Family family;
        double poda4ki;
        public double salary;
        public double netto;

        public double Poda4ki()
        {
            if (family == Family.Large)
            {
                poda4ki = 80.5;
            }
            else if (family == Family.Small)
            {
                poda4ki = 40.5;
            }
            return poda4ki;
        }



        public double Scholarship() 
        {
            if (specialization == Specialization.SoftwareDeveloper)
            {
                scholarship = 120.0;
            }
            else if (specialization == Specialization.Roboticist)
            {
                scholarship = 100.5;
            }
            else if (specialization == Specialization.Mathematician)
            {
                scholarship = 380.1;
            }

            scholarship += Poda4ki();
            return scholarship;
        }

        public void Change_Spec(Specialization newSpec) { specialization = newSpec; }

        public int ostlet()
        {
            if(specialization == Specialization.SoftwareDeveloper) 
            {
                vsego = 4;
            }
            else if(specialization == Specialization.Roboticist)
            {
                vsego=5;
            }
            else if(specialization == Specialization.Mathematician)
            {
                vsego = 8;
            }
            int ostalos = vsego - yearofstudy;
            return ostalos;
        }

        public Kutsekooliopilane(string name, int dateofbirth, Sex sex,Specialization specialization,Family family,string institution,int yearofstudy) : base(name, dateofbirth, sex)
        {
            this.specialization = specialization;
            this.family = family;   
            this.institution = institution;
            this.yearofstudy = yearofstudy;
        }

        public override double calSalary(double nonTaxRef, double tax)
        {
            netto = ((salary - nonTaxRef) * (1 - (tax / 100))) + nonTaxRef;
            return netto;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"CLASS >>> Kutsekooliopilane\nNAME >>> {name}\nAGE_OF_BIRTH >>> {dateofbirth}\nAGE >>> {base.calAge()}\nGENDER >>> {sex}\nFAMILY >>> {family}\nSPECIALIZATION >>> {specialization}\nINSTITUTION >>> {institution}\nYEAR_OF_STUDY >>> {yearofstudy}\nSCHOOLARSHIP >>> {Scholarship()}\nREMAINING_YEARS_OF_STUDY >>> {ostlet()}");
        }
    }
}
