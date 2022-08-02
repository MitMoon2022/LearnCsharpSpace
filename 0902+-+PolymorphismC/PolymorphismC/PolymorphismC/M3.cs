using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    class M3:BMW
    {

        public M3(int hp, string color, string model) : base(hp, color, model)
        {
            this.Model = model;
        }

        //cannot use this method because it is "sealed" in the inherited BMW class.
        //public override void Repair()
        //{
        //    base.Repair();
        //}
        
    }
}
