using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Skins.Library.Helpers;

namespace Skins.Library.Models
{
    public class Hole : ObservableObject
    {
        private int _par;
        public int Par 
        {
            get { return _par; }
            set
            {
                if (_par == value) return;

                _par = value;
                OnPropertyChanged("Par");
            }
        }

        private int _index;
        public int Index
        {
            get { return _index; }
            set 
            {
                if (_index == value) return;

                _index = value;
                OnPropertyChanged("Index");
            }
        }

        private int _what9;
        public int What9
        {
            get { return _what9; }
            set 
            {
                if (_what9 == value) return;

                _what9 = value;
                OnPropertyChanged("What9");
            }
        }

        private float _prizeMoney;
        public float PrizeMoney
        {
            get { return _prizeMoney; }
            set 
            {
                if (_prizeMoney == value) return;

                _prizeMoney = value;
                OnPropertyChanged("PrizeMoney");
                OnPropertyChanged("TotalPrizeMoney");
            }
        }
    }
}
