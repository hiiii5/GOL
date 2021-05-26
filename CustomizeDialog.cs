using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOL
{
	public partial class CustomizeDialog : Form
	{
		private static Form1 localCopy;
		public CustomizeDialog(Form1 copy)
		{
			InitializeComponent();
			CellColorSelectionDisplay.BackColor = Form1.CellColor;
			GridColorSelectionDisplay.BackColor = Form1.GridColor;
			LiveColorSelectionDisplay.BackColor = Form1.LifeColor;
			DeathColorSelectionDisplay.BackColor = Form1.DeathColor;
			localCopy = copy;
		}

		private void BackgroundColorSelectButton_Click(object sender, EventArgs e)
		{
			CellColorDialog.ShowDialog();
			CellColorSelectionDisplay.BackColor = CellColorDialog.Color;
			Form1.CellColor = CellColorDialog.Color;

			localCopy.Refresh();
		}

		private void GridColorSelectionButton_Click(object sender, EventArgs e)
		{
			GridColorDialog.ShowDialog();
			GridColorSelectionDisplay.BackColor = GridColorDialog.Color;
			Form1.GridColor = GridColorDialog.Color;

			localCopy.Refresh();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			LiveColorDialog.ShowDialog();
			LiveColorSelectionDisplay.BackColor = LiveColorDialog.Color;
			Form1.LifeColor = LiveColorDialog.Color;

			localCopy.Refresh();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DeathColorDialog.ShowDialog();
			DeathColorSelectionDisplay.BackColor = DeathColorDialog.Color;
			Form1.DeathColor = DeathColorDialog.Color;

			localCopy.Refresh();
		}

		private void DisplayNeighborsCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			localCopy.ShowAliveNeighbors = DisplayNeighborsCheckBox.Checked;
			localCopy.Refresh();
		}
	}
}
