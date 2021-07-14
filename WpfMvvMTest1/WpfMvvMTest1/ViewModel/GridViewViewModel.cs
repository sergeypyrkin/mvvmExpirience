using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using WpfMvvMTest1.Model;

namespace WpfMvvMTest1.ViewModel
{
    public class GridViewViewModel: ViewModelBase
    {

        public ObservableCollection<Marker> ListViewMarkers { get; set; } = new ObservableCollection<Marker>();
        private Marker _selectedMarker = null;

        public Marker SelectedMarker
        {
            get { return _selectedMarker; }
            set
            {
                if (_selectedMarker != value)
                {
                    _selectedMarker = value;
                    //SelectedMarkerChanged();
                    RaisePropertyChanged("SelectedMarker");
                }
            }
        }

        private string _Num;

        public string Num
        {
            get
            {
                return ListViewMarkers.Count.ToString();
            }
  
        }

        

        private string _number;
        public string Number
        {
            get { return _number; }
            set
            {
                _number = value;
                RaisePropertyChanged("Number");
            }
        }


        public GridViewViewModel()
        {

        }

        public GridViewViewModel(string number)
        {
            if (String.IsNullOrEmpty(number))
            {
                number = "10";
            }
            Number = number.ToString();
            fillMakrers();
        }

        private void fillMakrers()
        {
            int n = Convert.ToInt32(Number);
            for (int i = 0; i < n; i++)
            {
                Marker m1 = new Marker() { Id = i, Name = "С"+i, SurName = "Б"+i, TimeVideo = 123+n };
                ListViewMarkers.Add(m1);
            }
        }


        private RelayCommand _addNewk;
        public RelayCommand AddNew
        {
            get
            {
                return _addNewk ??
                       (_addNewk = new RelayCommand(() =>
                       {
                           Random r = new Random();
                           int n = r.Next(100);
                           Marker m1 = new Marker() { Id = n, Name = "С" + n, SurName = "Б" + n, TimeVideo = 123 + n };
                           ListViewMarkers.Add(m1);
                           RaisePropertyChanged("Num");

                       }));
            }
        }

        private RelayCommand _Remove;

        public RelayCommand Remove
        {
            get
            {
                return _Remove ??
                       (_Remove = new RelayCommand(() =>
                       {
                           if (SelectedMarker == null)
                           {
                               MessageBox.Show("Выберите маркер");
                               return;
                           }
                           ListViewMarkers.Remove(SelectedMarker);
                           SelectedMarker = null;
                           RaisePropertyChanged("Num");


                       }));
            }
        }

        private RelayCommand _Var;

        public RelayCommand Var
        {
            get
            {
                return _Var ??
                       (_Var = new RelayCommand(() =>
                       {

                       }));
            }
        }

        private RelayCommand _Command_GridView_MouseDoubleDown;

        public RelayCommand Command_GridView_MouseDoubleDown
        {
            get
            {
                return _Command_GridView_MouseDoubleDown ??
                       (_Command_GridView_MouseDoubleDown = new RelayCommand(() =>
                       {
                           MessageBox.Show(SelectedMarker.Id.ToString());
                       }));
            }
        }


        private RelayCommand<object> _Command_GridView_MouseDown;

        public RelayCommand<object> CommandGridView_MouseDown
        {
            get
            {
                return _Command_GridView_MouseDown ??
                       (_Command_GridView_MouseDown = new RelayCommand<object>((object e) =>
                       {
                           object[] objs = e as object[];
                           if (objs.Length == 2 && objs[0] is ListViewItem && objs[1] is MouseButtonEventArgs)
                           {
                               Marker itemMarker = ((ListViewItem) objs[0]).Content as Marker;
                               MouseButtonEventArgs btn = objs[1] as MouseButtonEventArgs;
                               if (btn.ChangedButton == MouseButton.Right)
                               {
                                   
                               }

                           }
                       }));
            }
        }
   
    }
}
