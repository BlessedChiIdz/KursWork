using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Input;
using Avalonia.VisualTree;
using KursWork.Models;
using KursWork.ViewModels;
using System.Linq;

namespace KursWork.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(this);
        }
        void PressedOnCanv(object sender, PointerPressedEventArgs args)
        {
            Point currentPointPos = args
                        .GetPosition(
                    this.GetVisualDescendants()
                    .OfType<Canvas>().FirstOrDefault()
                    );
            if (DataContext is MainWindowViewModel mw)
            {
                if (args.Source is Canvas canvas)
                {
                    if (mw.SelScheme == 0)
                    {
                        AndM am = new AndM();
                        Point point = currentPointPos;
                        am.StartPoint = point;
                        mw.COLL.Add(am);
                    }
                    if (mw.SelScheme == 1)
                    {
                        OrM om = new OrM();
                        Point point = currentPointPos;
                        om.StartPoint = point;
                        mw.COLL.Add(om);
                    }
                    if (mw.SelScheme == 2)
                    {
                        NoT nt = new NoT();
                        Point point = currentPointPos;

                        nt.StartPoint = point;
                        mw.COLL.Add(nt);
                    }
                }
                if (args.Source is Image img)
                {
                    if (img.DataContext is DModel dmod)
                    {
                        this.PointerMoved += MoveStruct;
                        this.PointerReleased += FreeStruct;
                    }
                }
                if (args.Source is Rectangle rec)
                {
                    if (rec.DataContext is DModel dmod)
                    {
                        this.PointerMoved += NewLink;
                        this.PointerReleased += StopLink;
                    }
                }
            }
        }
        void MoveStruct(object sender, PointerEventArgs args)
        {
            Point currentPointPos = args
                        .GetPosition(
                    this.GetVisualDescendants()
                    .OfType<Canvas>().FirstOrDefault()
                    );
            if (args.Source is Image img)
            {
                if (img.DataContext is DModel dmod)
                {
                    dmod.StartPoint = currentPointPos;
                }
            }
        }
        void FreeStruct(object sender, PointerReleasedEventArgs args)
        {
            this.PointerMoved -= MoveStruct;
            this.PointerReleased -= FreeStruct;
        }

        void NewLink(object sender, PointerEventArgs args)
        {
            Point currentPointPos = args
                        .GetPosition(
                    this.GetVisualDescendants()
                    .OfType<Canvas>().FirstOrDefault()
                    );

        }
    }
}
