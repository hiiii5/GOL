using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL
{
	class Save
	{
		public int Width { get; private set; }
		public int Height { get; private set; }
		public int Interval { get; private set; }
		public Color DeathColor { get; private set; }
		public Color LifeColor { get; private set; }
		public Color GridColor { get; private set; }
		public Color CellColor { get; private set; }
		public bool IsToroidal { get; private set; }
		public int Generations { get; private set; }
		public bool [,] Universe { get; private set; }

		public Save(int width, int height, int interval, Color deathColor, Color lifeColor, Color gridColor, Color cellColor, bool isToroidal, int generations, bool[,] universe)
		{
			Width = width;
			Height = height;
			Interval = interval;
			DeathColor = deathColor;
			LifeColor = lifeColor;
			GridColor = gridColor;
			CellColor = cellColor;
			IsToroidal = isToroidal;
			Generations = generations;
			Universe = universe;
		}

		/// <summary>
		/// Color is passed as red,green,blue and will be parsed using the comma as a seperator, this function requires prepared string input
		/// </summary>
		/// <param name="color"></param>
		/// <returns></returns>
		public static Color ParseColor(string color)
		{
			string[] colorData = color.Split(',');
			int red = int.Parse(colorData[0]);
			int green = int.Parse(colorData[1]);
			int blue = int.Parse(colorData[2]);

			return Color.FromArgb(red, green, blue);
		}

		public static bool[,] ParseUniverse(string universe)
		{
			// Remove array openings
			universe = universe.Substring(1, universe.Length-2);
			string[] splitUniverse = universe.Split('/');
			List<string[]> list = new List<string[]>();

			for (int i = 0; i < splitUniverse.Length; i++)
			{
				list.Add(splitUniverse[i].Split(','));
			}

			// Error on non uniform lengths
			bool[,] ret = new bool[list.Count, list[0].Length];

			for (int y = 0; y < list.Count; y++)
			{
				for (int x = 0; x < list[0].Length; x++)
				{
					ret[x, y] = bool.Parse(list.ToArray()[y][x]);
				}
			}

			return ret;
		}
	}
}
