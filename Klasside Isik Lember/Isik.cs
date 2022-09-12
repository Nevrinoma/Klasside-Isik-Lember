using Klasside_Isik_Lember;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static Klasside_Isik_Lember.Kutsekooliopilane;
using System.Xml.Linq;

namespace Klasside_Isik_Lember
{
    public abstract class Isik
    {
        public string name { get; set; }
        public int dateofbirth {get;set;}
        public enum Sex {Male, Female }
        public Sex sex;
        public enum Nationality { Estonian, British, Latvian, Italian }
        public Nationality nationality;
        public double weight;
        public double height;
        public string workPlace;

        public Isik(string name, int dateofbirth, Sex sex)
        {
            this.name = name;
            this.dateofbirth = dateofbirth;
            this.sex = sex;
        }

        public Isik(string name, int dateofbirth, Sex sex, Nationality nationality, double weight, double height)
        {
            this.name = name;
            this.dateofbirth = dateofbirth;
            this.sex = sex;
            this.nationality = nationality;
            this.weight = weight;
            this.height = height;
        }

        protected Isik(Sex sex, string name, int dateofbirth)
        {
            this.sex = sex;
            this.name = name;
            this.dateofbirth = dateofbirth;
        }


        public abstract void PrintInfo();

        public void change_Name(string newName) { name = newName; }

        public int calAge() 
        {
            int age = DateTime.Now.Year - dateofbirth;
            return age;
        }

        public abstract double calSalary(double nonTaxRef,double tax);

    }
}

