using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Class1 : ViewModelBase
    {
        private string _personName;
        public string personName
        {
            get { return _personName; }
            set { _personName = value;
                RaisePropertyChanged("personName");
            }
        }

        public Class1()
        {
            personName = "Hanka & Rafałek";
        }
    }
}
