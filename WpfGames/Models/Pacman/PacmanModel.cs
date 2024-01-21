using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfGames.Helpers;

namespace WpfGames.Models.Pacman
{
    internal class PacmanModel
    {

        private MapLoader _mLoader = new MapLoader(@"C:\Users\5\source\repos\WpfGames\WpfGames\Source\Map.txt");

        public Canvas GameMap = new Canvas();

        public PacmanModel()
        {
            BuildMap();
        }


        private void BuildMap()
        {
            for (int x = 0; x < _mLoader.Map.Count; x++)
            {
                for (int y = 0; y < _mLoader.Map[x].Count; y++)
                {
                    string imagePath;
                    switch (_mLoader.Map[x][y])
                    {
                        case CellType.Coin:
                            imagePath = @"C:\Users\5\source\repos\WpfGames\WpfGames\Source\Images\Dot.png";
                            break;
                        case CellType.Wall:
                            imagePath = @"C:\Users\5\source\repos\WpfGames\WpfGames\Source\Images\Block.png";
                            break;
                        default:
                            imagePath = string.Empty;
                            break;
                    }
                    if (!string.IsNullOrEmpty(imagePath))
                        AddMapItem(imagePath, x, y);
                }
            }    
        }


        private void AddMapItem(string imagePath, int x, int y)
        {
            var mapItem = new MapItem(imagePath, x, y);
            Canvas.SetLeft(mapItem, x * 16);
            Canvas.SetTop(mapItem, y * 16);
            GameMap.Children.Add(mapItem);
        }
    }
}
