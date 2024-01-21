using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfGames.Models.Pacman;

namespace WpfGames.ViewModels.Pacman
{
    internal class PacmanViewModel:BindableBase
    {
        
        private PacmanModel _pModel;

        public Canvas GameMap
        {
            get => _pModel.GameMap;
            set
            {
                _pModel.GameMap = value;
                RaisePropertyChanged(nameof(GameMap));
            }
        }

        public PacmanViewModel()
        {
            _pModel = new PacmanModel();
        }
    }
}
