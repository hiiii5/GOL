
namespace GOL
{
	partial class OptionsDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.Interval = new System.Windows.Forms.Label();
			this.IntervalBox = new System.Windows.Forms.NumericUpDown();
			this.cellWidthLabel = new System.Windows.Forms.Label();
			this.WidthBox = new System.Windows.Forms.NumericUpDown();
			this.cellHeightLabel = new System.Windows.Forms.Label();
			this.HeightBox = new System.Windows.Forms.NumericUpDown();
			this.SimulationTypeLabel = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.RandomizeButton = new System.Windows.Forms.Button();
			this.RandomizeSeed = new System.Windows.Forms.NumericUpDown();
			this.SeedLabel = new System.Windows.Forms.Label();
			this.OffsetByTimeCheckBox = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.IntervalBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WidthBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeightBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RandomizeSeed)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.Interval);
			this.flowLayoutPanel1.Controls.Add(this.IntervalBox);
			this.flowLayoutPanel1.Controls.Add(this.cellWidthLabel);
			this.flowLayoutPanel1.Controls.Add(this.WidthBox);
			this.flowLayoutPanel1.Controls.Add(this.cellHeightLabel);
			this.flowLayoutPanel1.Controls.Add(this.HeightBox);
			this.flowLayoutPanel1.Controls.Add(this.SimulationTypeLabel);
			this.flowLayoutPanel1.Controls.Add(this.comboBox1);
			this.flowLayoutPanel1.Controls.Add(this.SeedLabel);
			this.flowLayoutPanel1.Controls.Add(this.RandomizeSeed);
			this.flowLayoutPanel1.Controls.Add(this.RandomizeButton);
			this.flowLayoutPanel1.Controls.Add(this.OffsetByTimeCheckBox);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(70, 20, 50, 0);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(350, 181);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// Interval
			// 
			this.Interval.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Interval.AutoSize = true;
			this.Interval.Location = new System.Drawing.Point(73, 26);
			this.Interval.Name = "Interval";
			this.Interval.Size = new System.Drawing.Size(69, 13);
			this.Interval.TabIndex = 4;
			this.Interval.Text = "Interval in ms";
			// 
			// IntervalBox
			// 
			this.IntervalBox.Location = new System.Drawing.Point(148, 23);
			this.IntervalBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.IntervalBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.IntervalBox.Name = "IntervalBox";
			this.IntervalBox.Size = new System.Drawing.Size(120, 20);
			this.IntervalBox.TabIndex = 5;
			this.IntervalBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.IntervalBox.ValueChanged += new System.EventHandler(this.IntervalBox_ValueChanged);
			// 
			// cellWidthLabel
			// 
			this.cellWidthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cellWidthLabel.AutoSize = true;
			this.cellWidthLabel.Location = new System.Drawing.Point(73, 52);
			this.cellWidthLabel.Name = "cellWidthLabel";
			this.cellWidthLabel.Size = new System.Drawing.Size(71, 13);
			this.cellWidthLabel.TabIndex = 0;
			this.cellWidthLabel.Text = "Width of cells";
			this.cellWidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// WidthBox
			// 
			this.WidthBox.Location = new System.Drawing.Point(150, 49);
			this.WidthBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.WidthBox.Name = "WidthBox";
			this.WidthBox.Size = new System.Drawing.Size(120, 20);
			this.WidthBox.TabIndex = 1;
			this.WidthBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.WidthBox.ValueChanged += new System.EventHandler(this.WidthBox_ValueChanged);
			// 
			// cellHeightLabel
			// 
			this.cellHeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cellHeightLabel.AutoSize = true;
			this.cellHeightLabel.Location = new System.Drawing.Point(73, 78);
			this.cellHeightLabel.Name = "cellHeightLabel";
			this.cellHeightLabel.Size = new System.Drawing.Size(71, 13);
			this.cellHeightLabel.TabIndex = 3;
			this.cellHeightLabel.Text = "Width of cells";
			// 
			// HeightBox
			// 
			this.HeightBox.Location = new System.Drawing.Point(150, 75);
			this.HeightBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.HeightBox.Name = "HeightBox";
			this.HeightBox.Size = new System.Drawing.Size(120, 20);
			this.HeightBox.TabIndex = 2;
			this.HeightBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.HeightBox.ValueChanged += new System.EventHandler(this.HeightBox_ValueChanged);
			// 
			// SimulationTypeLabel
			// 
			this.SimulationTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.SimulationTypeLabel.AutoSize = true;
			this.SimulationTypeLabel.Location = new System.Drawing.Point(73, 105);
			this.SimulationTypeLabel.Name = "SimulationTypeLabel";
			this.SimulationTypeLabel.Size = new System.Drawing.Size(82, 13);
			this.SimulationTypeLabel.TabIndex = 7;
			this.SimulationTypeLabel.Text = "Simulation Type";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Toroidal",
            "Finite"});
			this.comboBox1.Location = new System.Drawing.Point(161, 101);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 6;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			// 
			// RandomizeButton
			// 
			this.RandomizeButton.Location = new System.Drawing.Point(73, 154);
			this.RandomizeButton.Name = "RandomizeButton";
			this.RandomizeButton.Size = new System.Drawing.Size(75, 23);
			this.RandomizeButton.TabIndex = 8;
			this.RandomizeButton.Text = "Randomize";
			this.RandomizeButton.UseVisualStyleBackColor = true;
			this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
			// 
			// RandomizeSeed
			// 
			this.RandomizeSeed.Location = new System.Drawing.Point(111, 128);
			this.RandomizeSeed.Name = "RandomizeSeed";
			this.RandomizeSeed.Size = new System.Drawing.Size(120, 20);
			this.RandomizeSeed.TabIndex = 9;
			// 
			// SeedLabel
			// 
			this.SeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.SeedLabel.AutoSize = true;
			this.SeedLabel.Location = new System.Drawing.Point(73, 131);
			this.SeedLabel.Name = "SeedLabel";
			this.SeedLabel.Size = new System.Drawing.Size(32, 13);
			this.SeedLabel.TabIndex = 10;
			this.SeedLabel.Text = "Seed";
			this.SeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// OffsetByTimeCheckBox
			// 
			this.OffsetByTimeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.OffsetByTimeCheckBox.AutoSize = true;
			this.OffsetByTimeCheckBox.Location = new System.Drawing.Point(154, 157);
			this.OffsetByTimeCheckBox.Name = "OffsetByTimeCheckBox";
			this.OffsetByTimeCheckBox.Size = new System.Drawing.Size(126, 17);
			this.OffsetByTimeCheckBox.TabIndex = 11;
			this.OffsetByTimeCheckBox.Text = "Offset by current time";
			this.OffsetByTimeCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.OffsetByTimeCheckBox.UseVisualStyleBackColor = true;
			// 
			// OptionsDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 181);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "OptionsDialog";
			this.Text = "ChangeDimensionsPopup";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.IntervalBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WidthBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeightBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RandomizeSeed)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label cellWidthLabel;
		private System.Windows.Forms.NumericUpDown WidthBox;
		private System.Windows.Forms.Label cellHeightLabel;
		private System.Windows.Forms.NumericUpDown HeightBox;
		private System.Windows.Forms.Label Interval;
		private System.Windows.Forms.NumericUpDown IntervalBox;
		private System.Windows.Forms.Label SimulationTypeLabel;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label SeedLabel;
		private System.Windows.Forms.NumericUpDown RandomizeSeed;
		private System.Windows.Forms.Button RandomizeButton;
		private System.Windows.Forms.CheckBox OffsetByTimeCheckBox;
	}
}