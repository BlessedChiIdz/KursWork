using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using KursWork.Models;
using KursWork.ViewModels;
using System.Collections.ObjectModel;

namespace KursWork.Views
{
    public partial class StartWind : Window
    {
        public StartWind()
        {
            InitializeComponent();
        }
        void Press(object sender, PointerPressedEventArgs args)
        {
            if(DataContext is MainWindowViewModel mw)
            {
                if (args.ClickCount == 2)
                {
                    mw.Read(mw.Projects[mw.SelIndex].PATH);
                }
            }
        }
    }
}
