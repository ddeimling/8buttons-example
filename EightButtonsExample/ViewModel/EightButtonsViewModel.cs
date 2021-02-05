using EightButtonsExample.Service;
using EightButtonsExample.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EightButtonsExample.ViewModel
{
    public class EightButtonsViewModel : ViewModelBase, IEightButtonsViewModel
    {
        private readonly IDiodeService _diodeService;
        private const int DIODE_ONE_ID = 1;
        private const int DIODE_TWO_ID = 2;
        private const int DIODE_THREE_ID = 3;
        private const int DIODE_FOUR_ID = 4;

        public ICommand ButtonOne { get; }
        public ICommand ButtonTwo { get; }
        public ICommand ButtonThree { get; }
        public ICommand ButtonFour { get; }

        public EightButtonsViewModel(IDiodeService diodeService)
        {
            this._diodeService = diodeService;
            ButtonOne = new RelayCommand(ButtonOne_Execute, (o) => _diodeService != null);
            ButtonTwo = new RelayCommand(ButtonTwo_Execute, (o) => _diodeService != null);
            ButtonThree = new RelayCommand(ButtonThree_Execute, (o) => _diodeService != null);
            ButtonFour = new RelayCommand(ButtonFour_Execute, (o) => _diodeService != null);
        }

        private void ButtonFour_Execute(object obj)
        {
            _diodeService.Switch(DIODE_FOUR_ID);
        }

        private void ButtonThree_Execute(object obj)
        {
            _diodeService.Switch(DIODE_THREE_ID);
        }

        private void ButtonTwo_Execute(object obj)
        {
            _diodeService.Switch(DIODE_TWO_ID);
        }

        private void ButtonOne_Execute(object obj)
        {
            _diodeService.Switch(DIODE_ONE_ID);
        }
    }
}
