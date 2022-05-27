using SCHOOL_BUS.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SCHOOL_BUS.ViewModels
{
    public class DriverViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        private bool popupisopen;

        public bool Popupisopen
        {
            get { return popupisopen; }
            set
            {
                popupisopen = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand Add { get; set; }
        public RelayCommand Exit { get; set; }
        public DriverViewModel()
        {
            Add=new RelayCommand(add);
            Exit=new RelayCommand(exit);
        }
        public void add(object p)
        {
            Popupisopen=true;

        }
        public void exit(object p)
        {
            Popupisopen=false;

        }
    }
}
