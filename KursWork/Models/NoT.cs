using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWork.Models
{
    public class NoT : DModel
    {
        private bool _finp;
        private bool _out;
        public override bool Logic()
        {
            if (FInp == true) return false;
            else return true;
        }
        public override string Name
        {
            get => "Not";
            
        }
    }
}
