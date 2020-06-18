using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class ViewModel: ViewModelBase
    {
        public ViewModel() {
            ListItems = new ObservableCollection<string> { "string1", "string2", "string3" };
        }

        private RelayCommand _removeCommand;

        public RelayCommand RemoveCommand {
            get {
                return _removeCommand ?? (_removeCommand = new RelayCommand(RemoveCommandAction, RemoveCommandCanExecute));
            }
        }

        private void RemoveCommandAction() {

        }

        private bool RemoveCommandCanExecute() {
            return true;
        }

        private RelayCommand _addCommand;

        public RelayCommand AddCommand {
            get {
                return _addCommand ?? (_addCommand = new RelayCommand(AddCommandAction));
            }
        }

        private void AddCommandAction() {

        }

        private RelayCommand _setIndexCommand;

        public RelayCommand SetIndexCommand {
            get {
                return _setIndexCommand ?? (_setIndexCommand = new RelayCommand(SetIndexCommandAction));
            }
        }

        private void SetIndexCommandAction() {

        }

        ObservableCollection<string> _listItems;

        public ObservableCollection<string> ListItems {
            get {
                return _listItems;
            }
            set {
                if (value != _listItems) {
                    _listItems = value;
                    RaisePropertyChanged(nameof(ListItems));
                }
            }
        }


    }
}
