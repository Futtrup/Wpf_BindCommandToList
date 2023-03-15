using System.Windows;
using System.Windows.Controls;
using Wpf_BindCommandToListBoxItem.Commands;

namespace Wpf_BindCommandToListBoxItem.ViewModels
{
    public class MainViewModel
    {
        public RelayCommand SelectCommand => _selectCommand ?? (_selectCommand = new RelayCommand(SelectCommandHandler, SelectCommandHandler_CanExecute));
        private RelayCommand _selectCommand;

        public ListBoxItem SelectedItem { get; set; }

        public MainViewModel() { }

        private void SelectCommandHandler(object data)
        {
            //If you are using a ListView instead, replace all references to ListBox with ListView and ListBoxItem with ListViewItem respectively.

            var selectedItem = (ListBoxItem)data;
            MessageBox.Show($"\nCommandParameter: {selectedItem.Content}\nDataBinding: {SelectedItem.Content}", "Selected Item");
        }

        private bool SelectCommandHandler_CanExecute(object data) => true;
    }
}
