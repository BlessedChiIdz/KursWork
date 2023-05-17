using Avalonia.Controls;
using KursWork.Models;
using KursWork.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace KursWork.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<DModel> Coll;
        private int selScheme = 0;
        public MainWindowViewModel(MainWindow mw)
        {
            Coll = new ObservableCollection<DModel>();
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
        public int SelScheme
        {
            get => selScheme;
        }
        public ObservableCollection<DModel> COLL
        {
            get => Coll;
            set => SetProperty(ref Coll, value);
        }
           
    }
}
