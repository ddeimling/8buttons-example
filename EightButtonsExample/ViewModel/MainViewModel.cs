using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightButtonsExample.ViewModel
{
    public class MainViewModel : ViewModelBase, IMainViewModel
    {
        private IViewModel _content;

        public IViewModel Content
        {
            get { return _content; }
            set { SetField(ref _content, value); }
        }

    }
}
