using Avalonia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWork.Models
{
    public class OrM : DModel
    {
        
        
        private bool _out;

        public static bool Logic(bool a, bool b)
        {
            return a | b;
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
            get => "Or";
        }
    }
}
