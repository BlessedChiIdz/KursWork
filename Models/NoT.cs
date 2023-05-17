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
        public static bool Logic(bool a)
        {
            if (a == true) return false;
            else return true;
        }
        public bool FInp
        {
            get => _finp;
            set => SetProperty(ref _finp, value);
        }
        public bool OP
        {
            get => _out;
            set
            {
                bool res = Logic(FInp);
                SetProperty(ref _out, res);
            }
        }
        public string Name
        {
            get => "Not";
        }
    }
}
