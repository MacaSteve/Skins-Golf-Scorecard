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
using System.Collections.ObjectModel;
using Skins.Library.Helpers;

namespace Skins.Library.Models
{
    public class Course : ObservableObject
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set 
            {
                if (_name == value) return;

                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public ObservableCollection<Hole> Holes { get; set; }
    }
}
