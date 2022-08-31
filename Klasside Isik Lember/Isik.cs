using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasside_Isik_Lember
{
    public abstract class Isik
    {
        public string name { get; set; }
        public int dateofbirth;
        public enum Sex {Male, Female }
        public Sex sex;
        public enum Nationality { Estonian, British, Latvian, Italian }
        public Nationality nationality;
        public double weight;
        public double height;

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

        //public Isik()

        public abstract void PrintInfo();

        public void change_Name(string newName) { name = newName; }

        public int calAge() 
        {
            int age = DateTime.Now.Year - dateofbirth;
            return age;
        }

        public abstract double calSalary(double nonTaxRef,double Tax);

    }
}
