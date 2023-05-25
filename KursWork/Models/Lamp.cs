using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWork.Models
{
    public partial class Lamp : DModel
    {
        [ObservableProperty]
        private bool _vision = false;
        public bool VisibleQ
        {
            get => _vision;
            set => SetProperty(ref _vision, value);
        }
    }
}
