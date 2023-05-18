using Avalonia.Controls;
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
        private int selScheme = 0;
        public MainWindowViewModel(MainWindow mw)
        {
            Coll = new ObservableCollection<DFigure>();
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
        void DelLink()
        {
            COLL.Remove(SelLink);
            if (COLL[SelLink.SLinkNumb] is DModel dModel)
            {
                if (SelLink.SInpNumb == 0) dModel.FInpC = false;
                if (SelLink.SInpNumb == 1) dModel.SInpC = false;
                if (SelLink.SInpNumb == 2) dModel.OInpC = false;
            }
            if (COLL[SelLink.ELinkNumb] is DModel dModel2)
            {
                if (SelLink.SInpNumb == 0) dModel2.FInpC = false;
                if (SelLink.SInpNumb == 1) dModel2.SInpC = false;
                if (SelLink.SInpNumb == 2) dModel2.OInpC = false;
            }
        }
        public int SelScheme
        {
            get => selScheme;
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
