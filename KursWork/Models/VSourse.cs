using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWork.Models
{
    public class VSourse : DModel
    {
        private bool voltage = true;
        public override bool Logic()
        {
            return true;
        }
        public override bool BOut
        {
            get => voltage;
        }
    }
}
