using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xml.Serialization;
using WpfGames.Models.Pacman;

namespace WpfGames.Helpers
{
    internal class MapLoader
    {

        private string _mapFilePath;

        public string MapFilePath
        {
            get => _mapFilePath;
            set => _mapFilePath = value;    
        }

        private string[] _rawMap;

        public readonly List<List<CellType>> Map = new List<List<CellType>>();

        public MapLoader(string mapFilePath)
        {
            _mapFilePath = mapFilePath;
            LoadRawMap();
            LoadFullMap();
        }

        private void  LoadRawMap()
        {
            _rawMap = File.ReadAllLines(_mapFilePath);
        }

        private void LoadFullMap()
        {
            for (int x = 0; x < _rawMap[0].Length; x++)
            {
                var mapRow = new List<CellType>();
                for (int y = 0; y < _rawMap.Length; y++)
                {
                    var type = CellType.Empty;
                    switch (_rawMap[y][x])
                    {
                        case '.':
                            type = CellType.Coin;
                            break;
                        case '#':
                            type = CellType.Wall;
                            break;
                        default:
                            break;
                    }
                    mapRow.Add(type);
                }
                Map.Add(mapRow);
            }
        }
    }
}
