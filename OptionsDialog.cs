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
	public partial class OptionsDialog : Form
	{
		Form1 form;
		bool ignoreEvent = false;

		public OptionsDialog(Form1 form1)
		{
			ignoreEvent = true;
			form = form1;
			InitializeComponent();
			WidthBox.Value = Form1.UniverseWidth;
			HeightBox.Value = Form1.UniverseHeight;
			IntervalBox.Value = Form1.Interval;
			if (form.SimulationIsToroidal)
				comboBox1.SelectedIndex = 0;
			else
				comboBox1.SelectedIndex = 1;
			ignoreEvent = false;
		}

		public void UpdateValues()
		{
			WidthBox.Value = Form1.UniverseWidth;
			HeightBox.Value = Form1.UniverseHeight;
			IntervalBox.Value = Form1.Interval;
		}

		private void WidthBox_ValueChanged(object sender, EventArgs e)
		{
			if (!ignoreEvent)
			{
				form.Pause();
				form.ResizeWorld((int)WidthBox.Value, (int)HeightBox.Value);
			}
		}

		private void HeightBox_ValueChanged(object sender, EventArgs e)
		{
			if (!ignoreEvent)
			{
				form.Pause();
				form.ResizeWorld((int)WidthBox.Value, (int)HeightBox.Value);
			}
		}

		private void IntervalBox_ValueChanged(object sender, EventArgs e)
		{
			if (!ignoreEvent)
			{
				form.Pause();
				form.ChangeTimerInterval((int)IntervalBox.Value);
			}
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!ignoreEvent)
			{
				form.Pause();
				if (comboBox1.SelectedIndex == 0)
					form.SimulationIsToroidal = true;
				else
					form.SimulationIsToroidal = false;

				form.Refresh();
			}
		}
	}
}
