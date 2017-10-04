using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MVVM.Annotations;

namespace MVVM
{
   public class DataDisplayModel:INotifyPropertyChanged
    {
        private ObservableCollection<PlayerModel> _Data { get; set; }
        public ObservableCollection<PlayerModel> Data {
            get => _Data;
            set
            {
                _Data = value;
                OnPropertyChanged();
            }
            
        }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
