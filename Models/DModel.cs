using Avalonia;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;

namespace KursWork.Models
{
    public abstract class DModel : ObservableObject
    {

        private bool _finp;
        private Point _finpP;
        private Point startPoint;
        private IBrush? stroke;
        private IBrush? fill;
        private double strokeThickness;
        private bool _sinp;
        private Point _sinpP;
        private Point _outP;

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
        public IBrush? Stroke
        {
            get => stroke;
            set => SetProperty(ref stroke, value);
        }
        public IBrush? Fill
        {
            get => fill;
            set => SetProperty(ref fill, value);
        }
        public double StrokeThickness
        {
            get => strokeThickness;
            set => SetProperty(ref strokeThickness, value);
        }
    }
}
