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
        private Point point5 = new Point(5, 5);
        private int globalFlag;
        
        private DModel startDMod = new DModel();
        private Link link = new Link();
        private Point DefPoint = new Point();
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
                        am.Numb = mw.Num;
                        mw.COLL.Add(am);
                    }
                    if (mw.SelScheme == 1)
                    {
                        OrM om = new OrM();
                        Point point = currentPointPos;
                        om.StartPoint = point;
                        om.Numb = mw.Num;
                        mw.COLL.Add(om);
                    }
                    if (mw.SelScheme == 2)
                    {
                        NoT nt = new NoT();
                        Point point = currentPointPos;
                        nt.Numb = mw.Num;
                        nt.StartPoint = point;
                        mw.COLL.Add(nt);
                    }
                    if (mw.SelScheme == 3)
                    {
                        XoR xr = new XoR();
                        Point point = currentPointPos;
                        xr.Numb = mw.Num;
                        xr.StartPoint = point;
                        mw.COLL.Add(xr);
                    }
                    if (mw.SelScheme == 4)
                    {
                        VSourse xr = new VSourse();
                        Point point = currentPointPos;
                        xr.Numb = mw.Num;
                        xr.StartPoint = point;
                        mw.COLL.Add(xr);
                    }
                    if (mw.SelScheme == 6)
                    {
                        Multipleks xr = new Multipleks();
                        Point point = currentPointPos;
                        xr.Numb = mw.Num;
                        xr.StartPoint = point;
                        mw.COLL.Add(xr);
                    }
                    if (mw.SelScheme == 5)
                    {
                        Lamp xr = new Lamp();
                        xr.VisibleQ = false;
                        Point point = currentPointPos;
                        xr.Numb = mw.Num;
                        xr.StartPoint = point;
                        mw.COLL.Add(xr);
                    }
                    mw.Num++;
                }
                if (args.Source is Image img)
                {
                    if (img.DataContext is DModel dmod)
                    {
                        mw.DModelForDelete = dmod;
                        this.PointerMoved += MoveStruct;
                        this.PointerReleased += FreeStruct;
                    }
                }
                if (args.Source is Rectangle rec)
                {
                    if (rec.DataContext is DModel dmod)
                    {
                        DefPoint = currentPointPos;
                        this.PointerMoved += NewLink;
                        this.PointerReleased += StopLink;
                    }
                }
                if(args.Source is Line line)
                {
                    if(line.DataContext is Link link)
                    {
                        mw.SelLink = link;
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
            if(DataContext is MainWindowViewModel mw)
            {
                if (args.Source is Image img)
                {
                    if (img.DataContext is DModel dmod)
                    {
                        dmod.StartPoint = currentPointPos;
                        for (int i = 0; i < mw.COLL.Count(); i++)
                        {
                            if (mw.COLL[i] is Link link)
                            {
                                if(dmod.Numb == link.SLinkNumb)
                                {
                                    if(link.SInpNumb == 0)
                                    {
                                        link.FPoint = dmod.FStartPoint + point5;
                                    }
                                    if (link.SInpNumb == 1)
                                    {
                                        link.FPoint = dmod.SStartPoint + point5;
                                    }
                                    if (link.SInpNumb == 2)
                                    {
                                        link.FPoint = dmod.OStartPoint + point5;
                                    }
                                    if (link.SInpNumb == 3 && dmod is Multipleks mx)
                                    {
                                        link.FPoint = mx.SidePoint + point5;
                                    }
                                }
                                if (dmod.Numb == link.ELinkNumb)
                                {
                                    if (link.EInpNumb == 0)
                                    {
                                        link.SPoint = dmod.FStartPoint + point5;
                                    }
                                    if (link.EInpNumb == 1)
                                    {
                                        link.SPoint = dmod.SStartPoint + point5;
                                    }
                                    if (link.EInpNumb == 2)
                                    {
                                        link.SPoint = dmod.OStartPoint + point5;
                                    }
                                    if (link.EInpNumb == 3 && dmod is Multipleks mx)
                                    {
                                        link.SPoint = mx.SidePoint + point5;
                                    }
                                }
                            }
                        }
                    }
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
            if(DataContext is MainWindowViewModel mw)
            {
                if(args.Source is Rectangle rec)
                {
                    if(rec.DataContext is DModel dModel)
                    {
                        
                        int flag = 100;
                        if (link != null) mw.COLL.Remove(link);
                        for (int i = 0; i < 10; i++) 
                        {
                            for(int j = 0; j < 10; j++)
                            {
                                Point tempP = new Point(i, j);
                                if(dModel.FStartPoint + tempP == DefPoint)
                                {
                                    flag = 0;
                                }
                                if (dModel.SStartPoint + tempP == DefPoint)
                                {
                                    flag = 1;
                                }
                                if (dModel.OStartPoint + tempP == DefPoint)
                                {
                                    flag = 2;
                                }
                                if(dModel is Multipleks multipleks)
                                {
                                    if(multipleks.SidePoint+ tempP == DefPoint)
                                    {
                                        flag = 3;
                                    }
                                }
                            }
                        }
                        if (flag == 0) { 
                            link = new Link
                            {
                                FPoint = dModel.FStartPoint + new Point(5, 5),
                                SPoint = currentPointPos,
                                SLinkNumb = dModel.Numb,
                                SInpNumb = 0
                            };
                            
                        }
                        if (flag == 1) { 
                            link = new Link
                            {
                                FPoint = dModel.SStartPoint + new Point(5, 5),
                                SPoint = currentPointPos,
                                SLinkNumb = dModel.Numb,
                                SInpNumb = 1
                            };
                            
                        }
                        if (flag == 2) { 
                            link = new Link
                            {
                                FPoint = dModel.OStartPoint + new Point(5, 5),
                                SPoint = currentPointPos,
                                SLinkNumb = dModel.Numb,
                                SInpNumb = 2,
                            };
                        }
                        if (flag == 3)
                        {
                            if (dModel is Multipleks mpx)
                            {
                                link = new Link
                                {
                                    FPoint = mpx.SidePoint + new Point(5, 5),
                                    SPoint = currentPointPos,
                                    SLinkNumb = dModel.Numb,
                                    SInpNumb = 3,
                                };
                            }
                        }
                        globalFlag = flag;
                        startDMod = dModel;
                        mw.COLL.Add(link);
                    }
                }
            }
        }
        void StopLink(object sender, PointerReleasedEventArgs args) 
        {
            this.PointerMoved -= NewLink;
            bool flag = false;
            if (DataContext is MainWindowViewModel mw)
            {

                Point currentPointPos = args
                            .GetPosition(
                        this.GetVisualDescendants()
                        .OfType<Canvas>().FirstOrDefault()
                        );
                for(int i = 0; i < mw.COLL.Count(); i++)
                {
                    if (mw.COLL[i] is DModel dModel)
                    {
                        for (int q = 0; q < 10; q++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                Point point = new Point(q, j);
                                if (dModel.FStartPoint + point == currentPointPos && ((globalFlag == 0 && startDMod.FInpC != true) || (globalFlag == 1 && startDMod.SInpC != true) || (globalFlag == 2 && startDMod.OInpC != true) || (globalFlag == 3 && startDMod is Multipleks mx1 && mx1.SideC != true)) && dModel.FInpC!=true) 
                                {
                                    dModel.FInpC = true;
                                    link.ELinkNumb = dModel.Numb;
                                    mw.COLL.Add(link);
                                    flag = true;
                                    link.EInpNumb = 0;
                                    if (globalFlag == 0) startDMod.FInpC = true;
                                    if (globalFlag == 1) startDMod.SInpC = true;
                                    if (globalFlag == 2) startDMod.OInpC = true;
                                    if (globalFlag == 3 && startDMod is Multipleks mpX) mpX.SideC = true;
                                }
                                if (dModel.SStartPoint + point == currentPointPos && ((globalFlag == 0 && startDMod.FInpC != true) || (globalFlag == 1 && startDMod.SInpC != true) || (globalFlag == 2 && startDMod.OInpC != true) || (globalFlag == 3 && startDMod is Multipleks mx2 && mx2.SideC != true)) && dModel.SInpC!=true)
                                {
                                    dModel.SInpC = true;
                                    link.ELinkNumb = dModel.Numb;
                                    mw.COLL.Add(link);
                                    flag = true;
                                    link.EInpNumb = 1;
                                    if (globalFlag == 0) startDMod.FInpC = true;
                                    if (globalFlag == 1) startDMod.SInpC = true;
                                    if (globalFlag == 2) startDMod.OInpC = true;
                                    if (globalFlag == 3 && startDMod is Multipleks mpX) mpX.SideC = true;
                                }
                                if (dModel.OStartPoint + point == currentPointPos && ((globalFlag == 0 && startDMod.FInpC != true) || (globalFlag == 1 && startDMod.SInpC != true) || (globalFlag == 2 && startDMod.OInpC != true) || (globalFlag == 3 && startDMod is Multipleks mx3 && mx3.SideC != true)) && dModel.OInpC!=true)
                                {
                                    dModel.OInpC = true;
                                    link.ELinkNumb = dModel.Numb;
                                    mw.COLL.Add(link);
                                    flag = true;
                                    link.EInpNumb = 2;
                                    if (globalFlag == 0) startDMod.FInpC = true;
                                    if (globalFlag == 1) startDMod.SInpC = true;
                                    if (globalFlag == 2) startDMod.OInpC = true;
                                    if (globalFlag == 3 && startDMod is Multipleks mpX) mpX.SideC = true;
                                }
                                if (dModel is Multipleks mpx && mpx.SidePoint + point == currentPointPos && ((globalFlag == 0 && startDMod.FInpC != true) || (globalFlag == 1 && startDMod.SInpC != true) || (globalFlag == 2 && startDMod.OInpC != true) || (globalFlag == 3 && startDMod is Multipleks mx4 && mx4.SideC != true)) && mpx.SideC != true)
                                {
                                    mpx.SideC = true;
                                    link.ELinkNumb = dModel.Numb;
                                    mw.COLL.Add(link);
                                    flag = true;
                                    link.EInpNumb = 3;
                                    if (globalFlag == 0) startDMod.FInpC = true;
                                    if (globalFlag == 1) startDMod.SInpC = true;
                                    if (globalFlag == 2) startDMod.OInpC = true;
                                    if (globalFlag == 3 && startDMod is Multipleks mpX) mpX.SideC = true;
                                }
                            }
                        }
                    }
                }
                if (flag == false) mw.COLL.Remove(link);
                if (flag == true) mw.Num++;
            }
                this.PointerReleased -= StopLink;
                if(DataContext is MainWindowViewModel mw1) mw1.ResetCOLL();
        }
    }
}




