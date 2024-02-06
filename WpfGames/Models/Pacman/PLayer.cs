using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfGames.Models.Pacman
{
    class PLayer : MapItem
    {

        public PLayer(string imagePath, int x, int y):base(imagePath, x, y)
        {
            Init(imagePath, x, y);
        }


    }
}
