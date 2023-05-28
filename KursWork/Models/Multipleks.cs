using Avalonia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWork.Models
{
    public class Multipleks : DModel
    {
        private bool SPC;
        private bool SP;
        private Point _finpP;
        private Point startPoint;
        private Point _sinpP;
        private Point _outP;
        private Point sidePoint;
        public override Point StartPoint
        {
            get => startPoint;
            set
            {
                SetProperty(ref startPoint, value);
                Point temp = new Point(0, 15);
                FStartPoint = startPoint + temp;
                temp = new Point(0, 40);
                SStartPoint = StartPoint + temp;
                temp = new Point(75, 28);
                OStartPoint = StartPoint + temp;
                temp = new Point(38, 58);
                SidePoint = StartPoint + temp;
            }
        }
        public Point SidePoint
        {
            get => sidePoint;
            set => SetProperty(ref sidePoint, value);
        }
        public bool SideC 
        {
            get => SPC;
            set => SetProperty(ref SPC, value);
        }
        public bool Side 
        {
            get => SP;
            set => SetProperty(ref SP, value);
        }
        public override bool Logic()
        {
            if (Side == false) return FInp;
            else return SInp;
        }
        public override string Name
        {
            get => "Multipleks";
        }
    }
}
