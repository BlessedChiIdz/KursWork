using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWork.Models
{
    public class AndM : DModel
    {
        private bool _finp;
        private bool _sinp;
        private bool _out;
        public override bool Logic()
        {
            return FInp & SInp;
        }
        public string Name
        {
            get => "And";
        }
    }
}
