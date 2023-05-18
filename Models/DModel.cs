using Avalonia;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;

namespace KursWork.Models
{
    public class DModel : DFigure
    {
        private bool _sinp;
        private bool _finp;
        private bool _fInpC;
        private bool _sInpC;
        private bool _oInpC;
        private Point _finpP;
        private Point startPoint;
        private Point _sinpP;
        private Point _outP;
        private int _numb;
        public Point SStartPoint
        {
            get => _sinpP;
            set => SetProperty(ref _sinpP, value);
        }
        public Point OStartPoint
        {
            get => _outP;
            set => SetProperty(ref _outP, value);
        }
        public bool SInp
        {
            get => _sinp;
            set => SetProperty(ref _sinp, value);
        }
        public Point FStartPoint
        {
            get => _finpP;
            set => SetProperty(ref _finpP, value);
        }
        
        public bool FInp
        {
            get => _finp;
            set => SetProperty(ref _finp, value);
        }
        public bool FInpC
        {
            get => _fInpC;
            set => SetProperty(ref _fInpC, value);
        }
        public bool SInpC
        {
            get => _sInpC;
            set => SetProperty(ref _sInpC, value);
        }
        public bool OInpC
        {
            get => _oInpC;
            set => SetProperty(ref _oInpC, value);
        }
        public int Numb
        {
            get => _numb;
            set => SetProperty(ref _numb,value);
        }
        public Point StartPoint
        {
            get => startPoint;
            set 
            {
                SetProperty(ref startPoint, value);
                Point temp = new Point(0,15);
                FStartPoint = startPoint + temp;
                temp = new Point(0, 40);
                SStartPoint = StartPoint + temp;
                temp = new Point(75, 28);
                OStartPoint = StartPoint + temp;
            } 
        }
    }
}
