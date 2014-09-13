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
using System.ComponentModel;
using Skins.Library.Models;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using Skins.Library.Helpers;

namespace Skins.Library.ViewModels
{
    public class GameViewModel : ObservableObject
    {
        public ObservableCollection<Players> Players { get; set; }
        public ObservableCollection<Hole> Holes { get; set; }

        public float TotalPrizeMoney
        {
            get { return Holes.Sum(h => h.PrizeMoney); }
        }
    }
}
