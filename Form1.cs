#define Dustin_Code

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GOL
{
	public partial class Form1 : Form
	{
#if Dustin_Code
		// Statically read by all forms, we only need one of each and we always read them
		public static int UniverseWidth = 10;
		public static int UniverseHeight = 10;
		public static int Interval = 20;

		// Maintain our options dialog for continuous screen feedback while changing options
		private static OptionsDialog optionsDialog;

		// Drawing colors
		public static Color DeathColor = Color.Red;
		public static Color LifeColor = Color.Green;
		
		public static Color GridColor = Color.Black;
		public static Color CellColor = Color.Gray;

		public bool SimulationIsToroidal = true;
#endif

		// The universe array
		bool[,] SimUniverse = new bool[UniverseWidth, UniverseHeight];

		// The Timer class
		Timer timer = new Timer();

		// Generation count
		int simGenerations = 0;

		public Form1()
		{
			InitializeComponent();

			// Setup the timer
			timer.Interval = Interval; // milliseconds
			timer.Tick += Timer_Tick;
			timer.Enabled = true; // start timer running
		}

#if Dustin_Code
		public void Pause()
		{
			pauseToolStripButton.Enabled = false;
			startToolStripButton.Enabled = true;
		}

		public void Resume()
		{
			pauseToolStripButton.Enabled = true;
			startToolStripButton.Enabled = false;
		}

		public void ChangeTimerInterval(int interval)
		{
			timer.Interval = interval;
			Interval = interval;
		}

		public void ResizeWorld(int width, int height)
		{
			if(optionsDialog != null)
				optionsDialog.UpdateValues();

			bool[,] temp = new bool[width, height];

			for (int y = 0; y < height - 1; y++)
			{
				for (int x = 0; x < width - 1; x++)
				{
					if (x < UniverseWidth - 1 && y < UniverseHeight - 1)
						temp[x, y] = SimUniverse[x, y];
					else
						temp[x, y] = false;
				}
			}

			SimUniverse = new bool[width, height];
			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
				{
					SimUniverse[x, y] = temp[x, y];
				}
			}

			UniverseWidth = width;
			UniverseHeight = height;

			Refresh();
		}

		// Error on non uniform grid size
		//Returns the number of cells in a ring around (x,y) that are alive.
		public int CountAliveNeighbours(int x, int y)
		{
			int count = 0;

			// Clamp to bounds
			int nb_x = x;
			int nb_y = y;

			for (int j = -1; j <= 1; j++)
			{
				for (int i = -1; i <= 1; i++)
				{
					// Set offsets for checking alive neighbors
					nb_x = x + i;
					nb_y = y + j;

					if (SimulationIsToroidal)
					{
						// Check x constraints
						if (nb_x < 0)
							nb_x = SimUniverse.GetLength(0) - 1;
						if (nb_x > SimUniverse.GetLength(0) - 1)
							nb_x = 0;

						// Check y constraints
						if (nb_y < 0)
							nb_y = SimUniverse.GetLength(1) - 1;
						if (nb_y > SimUniverse.GetLength(1) - 1)
							nb_y = 0;

						// Dont check for current position
						if (i == 0 && j == 0)
							continue;

						// increment on alive neighbors
						if (SimUniverse[nb_x, nb_y])
							count++;
					}
					else
					{
						// Check x constraints
						if (nb_x < 0 || nb_x >= SimUniverse.GetLength(0))
							continue;

						// Check y constraints
						if (nb_y < 0 || nb_y >= SimUniverse.GetLength(1))
							continue;

						// Dont check for current position
						if ((i == 0 && j == 0) || (nb_x == x && nb_y == y))
							continue;

						// increment on alive neighbors
						if (SimUniverse[nb_x, nb_y])
							count++;
					}
				}
			}

			return count;
		}
#endif

#if Dustin_Code

		// Calculate the next generation of cells
		private void NextGeneration()
		{

			bool[,] temp = new bool[SimUniverse.GetLength(0), SimUniverse.GetLength(1)];

			for (int y = 0; y < SimUniverse.GetLength(1); y++)
			{
				// Iterate through the universe in the x, left to right
				for (int x = 0; x < SimUniverse.GetLength(0); x++)
				{
					temp[x, y] = SimUniverse[x, y];
				}
			}

			// Iterate through the universe in the y, top to bottom
			for (int y = 0; y < SimUniverse.GetLength(1); y++)
			{
				// Iterate through the universe in the x, left to right
				for (int x = 0; x < SimUniverse.GetLength(0); x++)
				{
					int neighbors = CountAliveNeighbours(x, y);

					if (neighbors == 3)
						temp[x, y] = true;
					else if (neighbors == 2 && SimUniverse[x, y])
						temp[x, y] = true;
					else
						temp[x, y] = false;
				}
			}

			SimUniverse = temp;
			Refresh();
#endif

			// Increment generation count
			simGenerations++;

			// Update status strip generations
			toolStripStatusLabelGenerations.Text = "Generations = " + simGenerations.ToString();
			
		}

		// The event called by the timer every Interval milliseconds.
		private void Timer_Tick(object sender, EventArgs e)
		{
			if(startToolStripButton.Enabled == false)
				NextGeneration();
		}

		private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
		{
			// Calculate the width and height of each cell in pixels
			// CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
			int cellWidth = graphicsPanel1.ClientSize.Width / SimUniverse.GetLength(0);
			// CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
			int cellHeight = graphicsPanel1.ClientSize.Height / SimUniverse.GetLength(1);

			// A Pen for drawing the grid lines (color, width)
			Pen gridPen = new Pen(GridColor, 1);

			// A Brush for filling living cells interiors (color)
			Brush cellBrush = new SolidBrush(CellColor);

			// Iterate through the universe in the y, top to bottom
			for (int y = 0; y < SimUniverse.GetLength(1); y++)
			{
				// Iterate through the universe in the x, left to right
				for (int x = 0; x < SimUniverse.GetLength(0); x++)
				{
					cellBrush = new SolidBrush(CellColor);
					int neighbors = CountAliveNeighbours(x, y);
					// A rectangle 9to represent each cell in pixels
					Rectangle cellRect = Rectangle.Empty;
					cellRect.X = x * cellWidth;
					cellRect.Y = y * cellHeight;
					cellRect.Width = cellWidth;
					cellRect.Height = cellHeight;

					// Fill the cell with a brush if alive
					if (SimUniverse[x, y] == true)
					{
						e.Graphics.FillRectangle(cellBrush, cellRect);
					}

					// Outline the cell with a pen
					e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);

					if (SimUniverse[x, y])
					{
						if (neighbors < 2 || neighbors > 3)
							cellBrush = new SolidBrush(DeathColor);
						else
							cellBrush = new SolidBrush(LifeColor);
					}
					else
					{
						if (neighbors == 3)
							cellBrush = new SolidBrush(LifeColor);
						else
							cellBrush = new SolidBrush(DeathColor);
					}
					if(neighbors >= 1)
						e.Graphics.DrawString(neighbors.ToString(), DefaultFont, cellBrush, cellRect.Location);
				}
			}

			// Cleaning up pens and brushes
			gridPen.Dispose();
			cellBrush.Dispose();
		}

		private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
		{
			// If the left mouse button was clicked
			if (e.Button == MouseButtons.Left)
			{
				// Calculate the width and height of each cell in pixels
				int cellWidth = graphicsPanel1.ClientSize.Width / SimUniverse.GetLength(0);
				int cellHeight = graphicsPanel1.ClientSize.Height / SimUniverse.GetLength(1);

				// Calculate the cell that was clicked in
				// CELL X = MOUSE X / CELL WIDTH
				int x = e.X / cellWidth;
				// CELL Y = MOUSE Y / CELL HEIGHT
				int y = e.Y / cellHeight;

				// Toggle the cell's state
				SimUniverse[x, y] = !SimUniverse[x, y];

				// Tell Windows you need to repaint
				graphicsPanel1.Invalidate();
			}
		}

#if Dustin_Code
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void startToolStripButton_Click(object sender, EventArgs e)
		{
			pauseToolStripButton.Enabled = true;
			startToolStripButton.Enabled = false;
		}

		private void pauseToolStripButton_Click(object sender, EventArgs e)
		{
			pauseToolStripButton.Enabled = false;
			startToolStripButton.Enabled = true;
		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			optionsDialog = new OptionsDialog(this);
			optionsDialog.UpdateValues();
			optionsDialog.Show();
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Pause();
			SimUniverse = new bool[UniverseWidth, UniverseHeight];
			for (int i = 0; i < SimUniverse.GetLength(1); i++)
			{
				for (int j = 0; j < SimUniverse.GetLength(0); j++)
				{
					SimUniverse[j, i] = false;
				}
			}
			Refresh();
		}

		private void newToolStripButton_Click(object sender, EventArgs e)
		{
			Pause();
			SimUniverse = new bool[UniverseWidth, UniverseHeight];
			for (int i = 0; i < SimUniverse.GetLength(1); i++)
			{
				for (int j = 0; j < SimUniverse.GetLength(0); j++)
				{
					SimUniverse[j, i] = false;
				}
			}
			simGenerations = 0;
			Refresh();
		}

		private void NextToolstripButton_Click(object sender, EventArgs e)
		{
			NextGeneration();
		}

		private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CustomizeDialog dialog = new CustomizeDialog(this);
			dialog.Show();
		}

		private void saveToolStripButton_Click(object sender, EventArgs e)
		{
			
		}

		private void SaveToFile(string filepath)
		{
			if(!filepath.Contains(".sav"))
			{
				filepath += ".sav";
			}


		}

		private void ProcessSave(List<string> data, char dataSeperator = ':')
		{
			// setup data
			string width = data[0].Split(dataSeperator)[1];
			string height = data[1].Split(dataSeperator)[1];
			string interval = data[2].Split(dataSeperator)[1];
			string deathColor = data[3].Split(dataSeperator)[1];
			string lifeColor = data[4].Split(dataSeperator)[1];
			string gridColor = data[5].Split(dataSeperator)[1];
			string cellColor = data[6].Split(dataSeperator)[1];
			string isToroidal = data[7].Split(dataSeperator)[1];
			string generations = data[8].Split(dataSeperator)[1];
			string universe = data[9].Split(dataSeperator)[1];

			int saveWidth = int.Parse(width);
			int saveHeight = int.Parse(height);
			int saveInterval = int.Parse(interval);
			Color saveDeathColor = Save.ParseColor(deathColor);
			Color saveLifeColor = Save.ParseColor(lifeColor);
			Color saveGridColor = Save.ParseColor(gridColor);
			Color saveCellColor = Save.ParseColor(cellColor);
			bool saveIsToroidal = bool.Parse(isToroidal);
			int saveGeneration = int.Parse(generations);
			bool[,] saveUniverse = Save.ParseUniverse(universe);

			Save s = new Save(saveWidth, saveHeight, saveInterval, saveDeathColor, saveLifeColor, saveGridColor, saveCellColor, saveIsToroidal, saveGeneration, saveUniverse);

			UniverseWidth = s.Width;
			UniverseHeight = s.Height;
			Interval = s.Interval;
			DeathColor = s.DeathColor;
			LifeColor = s.LifeColor;
			GridColor = s.GridColor;
			CellColor = s.CellColor;
			SimulationIsToroidal = s.IsToroidal;
			simGenerations = s.Generations;
			SimUniverse = s.Universe;
		}

		private List<string> LoadSave(string filepath, char lineSeperator = ';')
		{
			if (!filepath.Contains(".sav"))
			{
				filepath += ".sav";
			}

			List<string> ret = null;

			if (!File.Exists(filepath))
				return null;

			string text = "";
			using (StreamReader stream = new StreamReader(@filepath))
			{
				 text = stream.ReadToEnd();
				stream.Close();
			}

			if (text == string.Empty || text == "" || text == "\0")
				return null;

			string[] split = text.Split(lineSeperator);

			ret = new List<string>();

			foreach (var s in split)
				ret.Add(s);

			return ret;
		}
#endif
	}
}
