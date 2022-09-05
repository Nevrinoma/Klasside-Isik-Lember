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
        public int ostalos { get; set; }

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
            ostalos = vsego - yearofstudy;
            return ostalos;
        }








        public Kutsekooliopilane(string name, int dateofbirth, Sex sex,Specialization specialization,string institution,int yearofstudy,double scholarship) : base(name, dateofbirth, sex)
        {
            this.specialization = specialization;
            this.institution = institution;
            this.yearofstudy = yearofstudy;
            this.scholarship = scholarship;
        }

        public override double calSalary(double nonTaxRef, double Tax)
        {
            throw new NotImplementedException();
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"CLASS >>> Kutsekooliopilane\nNAME >>> {name}\nAGE_OF_BIRTH >>> {dateofbirth}\nAGE >>> {age}\nGENDER >>> {sex}\nSPECIALIZATION >>> {specialization}\nINSTITUTION >>> {institution}\nYEAR_OF_STUDY >>> {yearofstudy}\nSCHOOLARSHIP >>> {scholarship}\nREMAINING_YEARS_OF_STUDY >>> {ostalos}");
        }
    }
}
