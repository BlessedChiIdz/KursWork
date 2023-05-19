using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWork.Models
{
    public class DFigure : ObservableObject
    {
        private bool _test;
        public bool Test
        {
            get => _test;
        }
    }
}
