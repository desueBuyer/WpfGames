using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WpfGames.Models.Pacman
{
    internal class MapItem : Image, IMapObject
    {
        public int X{get; set;}
        public int Y { get; set; }

        public MapItem(string imagePath, int x, int y)
        {
            Init(imagePath, x, y);
        }

        public void Init(string imagePath, int x, int y)
        {
            X = x;
            Y = y;
            LoadImage(imagePath);
        }

        public void LoadImage(string imagePath)
        {
            this.Source = new BitmapImage(new Uri(imagePath));
            this.Width = 16;
            this.Height = 16;
        }
    }
}
