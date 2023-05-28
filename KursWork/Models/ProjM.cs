using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWork.Models
{
    public class ProjM : ObservableObject
    {
        private string _path;

        public string Path
        {
            get => _path;
            set => SetProperty(ref _path, value);
        }
    }
}
