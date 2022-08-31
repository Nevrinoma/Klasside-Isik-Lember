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
        



        public Tootaja(string name, int dateofbirth, Sex sex,Post post,string workPlace,double salary ) : base(name, dateofbirth, sex)
        {
            this.post = post;
            this.workPlace = workPlace;
            this.salary = salary;
        }

        public override double calSalary(double nonTaxRef,double tax)
        {
            double netto = ((salary - nonTaxRef) * (1 - (tax / 100)));
            return netto;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"NAME >>> {name}\nAGE_OF_BIRTH >>> {dateofbirth}\nAGE >>> ---\nGENDER >>> {sex}\nPOST >>> {post}\nWORK_PLACE >>> {workPlace}\nSALARY >>> {netto}");
        }
    }
    

}
