using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWork.Models
{
    public class XoR : DModel
    {
        private bool _out;

        public override bool Logic()
        {
            return FInp ^ SInp;
        }
        public override string Name
        {
            get => "Xor";
        }
    }
}
