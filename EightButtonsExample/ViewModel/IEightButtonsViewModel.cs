using System.Windows.Input;

namespace EightButtonsExample.ViewModel
{
    public interface IEightButtonsViewModel
    {
        ICommand ButtonFour { get; }
        ICommand ButtonOne { get; }
        ICommand ButtonThree { get; }
        ICommand ButtonTwo { get; }
    }
}