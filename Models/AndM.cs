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
        public static bool Logic(bool a, bool b)
        {
            return a & b;
        }
        public bool FInp
        {
            get => _finp;
            set => SetProperty(ref _finp, value);
        }
        public bool SInp
        {
            get => _sinp;
            set => SetProperty(ref _sinp, value);
        }
        public bool OP
        {
            get => _out;
            set 
            {
                bool res = Logic(SInp, FInp);
                SetProperty(ref _out, res);
            }
        }
        public string Name
        {
            get => "And";
        }
    }
}
