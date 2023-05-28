using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWork.Models
{
    public class Empty : DFigure
    {
        private int _num;
        public int NUM
        {
            get => _num;
            set => SetProperty(ref _num, value);
        }
    }
}
