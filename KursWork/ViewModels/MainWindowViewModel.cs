using Avalonia.Controls;
using Avalonia.Media.Imaging;
using KursWork.Models;
using KursWork.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace KursWork.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private Link _link;
        private ObservableCollection<DFigure> Coll;
        private int _num = 0;
        private bool Pflag = false; 
        private int selScheme = 0;
        private DModel dModelForDelete;
        public MainWindowViewModel(MainWindow mw)
        {
            Coll = new ObservableCollection<DFigure>();
        }
        public int Num
        {
            get => _num;
            set => SetProperty(ref _num, value);
        }
        void SetAnd()
        {
            selScheme = 0;
        }
        void SetOr()
        {
            selScheme = 1;
        }
        void SetNt()
        {
            selScheme = 2;
        }
        void SetXor()
        {
            selScheme = 3;
        }
        void VSourse()
        {
            selScheme = 4;
        }
        void MultiP()
        {
            selScheme = 6;
        }
        void OutPut()
        {
            selScheme = 5;
        }
        public void ResetCOLL()
        {
            bool flag = false;
            for(int qwe = 0; qwe < Num; qwe++) { 
            for(int i = 0; i < COLL.Count(); i++)
            {
                if (COLL[i] is DModel dModel)
                {
                    if (dModel is Multipleks mks && mks.SideC==false) { mks.Side = false; }
                    if(dModel.FInpC == false) { dModel.FInp = false; }
                    else
                    {
                        for(int j = 0; j < COLL.Count(); j++)
                        {
                            if (COLL[j] is Link link) 
                            { 
                                if(link.SLinkNumb == dModel.Numb) 
                                { 
                            
                                    if(link.SInpNumb == 2)
                                    {
                                        if(COLL[link.ELinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel1.FInp = dModel.Logic();
                                            if (link.EInpNumb == 1) dModel1.SInp = dModel.Logic();
                                            if (link.EInpNumb == 3 && dModel1 is Multipleks mx) mx.Side = dModel.Logic();
                                        }
                                    }
                                    if(link.EInpNumb == 2)
                                    {
                                        if (COLL[link.ELinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel.FInp = dModel1.Logic();
                                            if (link.EInpNumb == 1) dModel.SInp = dModel1.Logic();
                                            if (link.EInpNumb == 3 && dModel is Multipleks mx) mx.Side = dModel1.Logic();
                                        }
                                    }
                            
                                }
                                if (link.ELinkNumb == dModel.Numb)
                                {

                                    if (link.SInpNumb == 2)
                                    {
                                        if (COLL[link.SLinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel.FInp = dModel1.Logic();
                                            if (link.EInpNumb == 1) dModel.SInp = dModel1.Logic();
                                            if (link.EInpNumb == 3 && dModel is Multipleks mx) mx.Side = dModel1.Logic();
                                        }
                                    }
                                    if (link.EInpNumb == 2)
                                    {
                                        if (COLL[link.SLinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel1.FInp = dModel.Logic();
                                            if (link.EInpNumb == 1) dModel1.SInp = dModel.Logic();
                                            if (link.EInpNumb == 3 && dModel1 is Multipleks mx) mx.Side = dModel.Logic();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if(dModel.SInpC == false) { dModel.SInp = false; }
                    else
                    {
                        for (int j = 0; j < COLL.Count(); j++)
                        {
                            if (COLL[j] is Link link)
                            {
                                if (link.SLinkNumb == dModel.Numb)
                                {

                                    if (link.SInpNumb == 2)
                                    {
                                        if (COLL[link.ELinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel1.FInp = dModel.Logic();
                                            if (link.EInpNumb == 1) dModel1.SInp = dModel.Logic();
                                            if (link.EInpNumb == 3 && dModel1 is Multipleks mx) mx.Side = dModel.Logic();
                                        }
                                    }
                                    if (link.EInpNumb == 2)
                                    {
                                        if (COLL[link.ELinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel.FInp = dModel1.Logic();
                                            if (link.EInpNumb == 1) dModel.SInp = dModel1.Logic();
                                            if (link.EInpNumb == 3 && dModel is Multipleks mx) mx.Side = dModel1.Logic();
                                        }
                                    }

                                }
                                if (link.ELinkNumb == dModel.Numb)
                                {

                                    if (link.SInpNumb == 2)
                                    {
                                        if (COLL[link.ELinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel.FInp = dModel1.Logic();
                                            if (link.EInpNumb == 1) dModel.SInp = dModel1.Logic();
                                            if (link.EInpNumb == 3 && dModel is Multipleks mx) mx.Side = dModel1.Logic();
                                            }
                                    }
                                    if (link.EInpNumb == 2)
                                    {
                                        if (COLL[link.ELinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel1.FInp = dModel.Logic();
                                            if (link.EInpNumb == 1) dModel1.SInp = dModel.Logic();
                                            if (link.EInpNumb == 3 && dModel1 is Multipleks mx) mx.Side = dModel.Logic();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (dModel.OInpC == false) { dModel.BOut = false; }
                    else
                    {
                        for (int j = 0; j < COLL.Count(); j++)
                        {
                            if (COLL[j] is Link link)
                            {
                                if (link.SLinkNumb == dModel.Numb)
                                {

                                    if (link.SInpNumb == 2)
                                    {
                                        if (COLL[link.ELinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel1.FInp = dModel.Logic();
                                            if (link.EInpNumb == 1) dModel1.SInp = dModel.Logic();
                                            if (link.EInpNumb == 3 && dModel1 is Multipleks mx) mx.Side = dModel.Logic();
                                            }
                                    }
                                    if (link.EInpNumb == 2)
                                    {
                                        if (COLL[link.ELinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel.FInp = dModel1.Logic();
                                            if (link.EInpNumb == 1) dModel.SInp = dModel1.Logic();
                                            if (link.EInpNumb == 3 && dModel is Multipleks mx) mx.Side = dModel1.Logic();
                                        }
                                    }

                                }
                                if (link.ELinkNumb == dModel.Numb)
                                {

                                    if (link.SInpNumb == 2)
                                    {
                                        if (COLL[link.ELinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel.FInp = dModel1.Logic();
                                            if (link.EInpNumb == 1) dModel.SInp = dModel1.Logic();
                                            if (link.EInpNumb == 3 && dModel is Multipleks mx) mx.Side = dModel1.Logic();
                                        }
                                    }
                                    if (link.EInpNumb == 2)
                                    {
                                        if (COLL[link.ELinkNumb] is DModel dModel1)
                                        {
                                            if (link.EInpNumb == 0) dModel1.FInp = dModel.Logic();
                                            if (link.EInpNumb == 1) dModel1.SInp = dModel.Logic();
                                            if (link.EInpNumb == 3 && dModel1 is Multipleks mx) mx.Side = dModel.Logic();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            }
            for (int i = 0; i < COLL.Count(); i++)
            {
                if (COLL[i] is Lamp lamp)
                {
                    if (lamp.FInp == true) lamp.VisibleQ = true;
                    if (lamp.FInp == false) lamp.VisibleQ = false;
                }
            }
        }
        void DelLink()
        {
            if(SelLink != null)
            {
                COLL.Remove(SelLink);
                COLL.Remove(SelLink);
                if (COLL[SelLink.SLinkNumb] is DModel dModel)
                {
                    if (SelLink.SInpNumb == 0) { dModel.FInpC = false; }
                    if (SelLink.SInpNumb == 1) { dModel.SInpC = false; }
                    if (SelLink.SInpNumb == 2) { dModel.OInpC = false; }
                    if (SelLink.SInpNumb == 3 && dModel is Multipleks mx) { mx.SideC = false; }
                }
                if (COLL[SelLink.ELinkNumb] is DModel dModel2)
                {
                    if (SelLink.EInpNumb == 0) { dModel2.FInpC = false; }
                    if (SelLink.EInpNumb == 1) { dModel2.SInpC = false; }
                    if (SelLink.EInpNumb == 2) { dModel2.OInpC = false; }
                    if (SelLink.EInpNumb == 3 && dModel2 is Multipleks mx) { mx.SideC = false; }
                }
                Num--;
                ResetCOLL();
            }
            if (DModelForDelete != null)
            {
                COLL[DModelForDelete.Numb] = null;
            }
        }
        public int SelScheme
        {
            get => selScheme;
        }
        public DModel DModelForDelete
        {
            get => dModelForDelete;
            set => SetProperty(ref dModelForDelete, value);
        }
        public Link SelLink
        {
            get => _link;
            set => SetProperty(ref _link, value);
        }
        public ObservableCollection<DFigure> COLL
        {
            get => Coll;
            set => SetProperty(ref Coll, value);
        }
        
    }
}
