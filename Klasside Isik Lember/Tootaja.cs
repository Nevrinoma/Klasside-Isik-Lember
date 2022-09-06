using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Klasside_Isik_Lember
{
    class Tootaja : Isik
    {
        public string workPlace;
        public enum Post { Clerk, Manager, Boss }
        Post post;
        public double salary;
        public double netto;

        public void Change_Post(Post newPost) { post = newPost; }


        public Tootaja(string name, int dateofbirth, Sex sex,Post post,string workPlace,double salary ) : base(name, dateofbirth, sex)
        {
            this.post = post;
            this.workPlace = workPlace;
            this.salary = salary;
        }

        public override double calSalary(double nonTaxRef,double tax)
        {
            netto = ((salary - nonTaxRef) * (1 - (tax / 100)))+nonTaxRef;
            return netto;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"CLASS >>> Tootaja\nNAME >>> {name}\nAGE_OF_BIRTH >>> {dateofbirth}\nAGE >>> {base.calAge()}\nGENDER >>> {sex}\nPOST >>> {post}\nWORK_PLACE >>> {workPlace}\nSALARY >>> {netto}");
        }









    }
    

}
