using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    class ViewModel : BindableBase
    {
        public string Text
        {
            get { return _Text; }
            set { SetProperty(ref _Text, value); }
        }
        private string _Text;

        public MenuType Type
        {
            get { return _Type; }
            set { SetProperty(ref _Type, value); }
        }
        private MenuType _Type = MenuType.AAA;

    }
}
