using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;

namespace TestComboHidden
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<ClampRecord> _clampRecords = new ObservableCollection<ClampRecord>(); 
        public ObservableCollection<ClampRecord> ClampRecords { get => _clampRecords; set { Set(() => ClampRecords, ref _clampRecords, value); }}

        public MainWindowViewModel()
        {
            loadClamps();

        }

        private RelayCommand _addClampCmd;
        public RelayCommand AddClampCmd => _addClampCmd ?? (_addClampCmd = new RelayCommand(
            () => addClamp(),
            () => { return 1 == 1; } 
            ));

        private RelayCommand _removeClampCmd;
        public RelayCommand RemoveClampCmd => _removeClampCmd ?? (_removeClampCmd = new RelayCommand(
            () => removeClamp(),
            () => ClampRecords.Count>1 
            ));

        public Visibility ShowComboBox => ClampRecords.Count() > 1 ? Visibility.Visible : Visibility.Collapsed;

        private void addClamp()
        {
            Random random = new Random();
            int i = random.Next(0, 100);
            ClampRecords.Add(new ClampRecord($"Name{i}", i));
        }

        private void removeClamp()
        {
            if (ClampRecords.Count > 1)
                ClampRecords.RemoveAt(0);
        }

        private void loadClamps()
        {
            addClamp();
           addClamp();
            //addClamp();
        }

    }
}
