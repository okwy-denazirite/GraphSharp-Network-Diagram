using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphSharpDiagram.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<ItemViewModel>
      items = new ObservableCollection<ItemViewModel>();
        private int selectedindex;

        public ObservableCollection<ItemViewModel> Items
        {
            get
            {
                return items;
               
            }

        }

        public int SelectedIndex
        {
            get { return selectedindex; }
            set
            {
                selectedindex = value;
                OnPropertyChanged("SelectedIndex");
            }
        }

    }
}
