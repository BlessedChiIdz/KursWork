using Avalonia;
using CommunityToolkit.Mvvm.ComponentModel;

namespace KursWork.Models
{
    public class Link : DFigure
    {
        private Point _fPoint;
        private Point _sPoint;
        private int _sLinkNum;
        private int _eLinkNum;
        private int _sinpNumb;
        private int _einpNumb;
        public Point FPoint
        {
            get => _fPoint;
            set => SetProperty(ref _fPoint, value);
        }
        public Point SPoint
        {
            get => _sPoint;
            set 
            {
            SetProperty(ref _sPoint, value);
            
            } 
        }
        public int SLinkNumb
        {
            get => _sLinkNum;
            set => SetProperty(ref _sLinkNum, value);
        }
        public int ELinkNumb
        {
            get => _eLinkNum;
            set => SetProperty(ref _eLinkNum, value);
        }
        public int SInpNumb
        {
            get => _sinpNumb;
            set => SetProperty(ref _sinpNumb, value);
        }
        public int EInpNumb
        {
            get => _einpNumb;
            set => SetProperty(ref _einpNumb, value);
        }
    }
}
