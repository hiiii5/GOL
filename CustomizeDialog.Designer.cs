
namespace GOL
{
	partial class CustomizeDialog
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
			this.CellColorLabel = new System.Windows.Forms.Label();
			this.CellColorSelectButton = new System.Windows.Forms.Button();
			this.CellColorSelectionDisplay = new System.Windows.Forms.TextBox();
			this.GridColorLabel = new System.Windows.Forms.Label();
			this.GridColorSelectionButton = new System.Windows.Forms.Button();
			this.GridColorSelectionDisplay = new System.Windows.Forms.TextBox();
			this.LiveColorLabel = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.LiveColorSelectionDisplay = new System.Windows.Forms.TextBox();
			this.DeathColorLabel = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.DeathColorSelectionDisplay = new System.Windows.Forms.TextBox();
			this.CellColorDialog = new System.Windows.Forms.ColorDialog();
			this.GridColorDialog = new System.Windows.Forms.ColorDialog();
			this.LiveColorDialog = new System.Windows.Forms.ColorDialog();
			this.DeathColorDialog = new System.Windows.Forms.ColorDialog();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.CellColorLabel);
			this.flowLayoutPanel1.Controls.Add(this.CellColorSelectButton);
			this.flowLayoutPanel1.Controls.Add(this.CellColorSelectionDisplay);
			this.flowLayoutPanel1.Controls.Add(this.GridColorLabel);
			this.flowLayoutPanel1.Controls.Add(this.GridColorSelectionButton);
			this.flowLayoutPanel1.Controls.Add(this.GridColorSelectionDisplay);
			this.flowLayoutPanel1.Controls.Add(this.LiveColorLabel);
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Controls.Add(this.LiveColorSelectionDisplay);
			this.flowLayoutPanel1.Controls.Add(this.DeathColorLabel);
			this.flowLayoutPanel1.Controls.Add(this.button2);
			this.flowLayoutPanel1.Controls.Add(this.DeathColorSelectionDisplay);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(50, 20, 50, 0);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(214, 157);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// CellColorLabel
			// 
			this.CellColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.CellColorLabel.AutoSize = true;
			this.CellColorLabel.Location = new System.Drawing.Point(53, 28);
			this.CellColorLabel.Name = "CellColorLabel";
			this.CellColorLabel.Size = new System.Drawing.Size(51, 13);
			this.CellColorLabel.TabIndex = 0;
			this.CellColorLabel.Text = "Cell Color";
			// 
			// CellColorSelectButton
			// 
			this.CellColorSelectButton.Location = new System.Drawing.Point(110, 23);
			this.CellColorSelectButton.Name = "CellColorSelectButton";
			this.CellColorSelectButton.Size = new System.Drawing.Size(14, 23);
			this.CellColorSelectButton.TabIndex = 2;
			this.CellColorSelectButton.Text = ">";
			this.CellColorSelectButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.CellColorSelectButton.UseVisualStyleBackColor = true;
			this.CellColorSelectButton.Click += new System.EventHandler(this.BackgroundColorSelectButton_Click);
			// 
			// CellColorSelectionDisplay
			// 
			this.CellColorSelectionDisplay.Enabled = false;
			this.CellColorSelectionDisplay.Location = new System.Drawing.Point(130, 23);
			this.CellColorSelectionDisplay.Name = "CellColorSelectionDisplay";
			this.CellColorSelectionDisplay.Size = new System.Drawing.Size(20, 20);
			this.CellColorSelectionDisplay.TabIndex = 1;
			// 
			// GridColorLabel
			// 
			this.GridColorLabel.AutoSize = true;
			this.GridColorLabel.Location = new System.Drawing.Point(53, 49);
			this.GridColorLabel.Name = "GridColorLabel";
			this.GridColorLabel.Size = new System.Drawing.Size(50, 13);
			this.GridColorLabel.TabIndex = 3;
			this.GridColorLabel.Text = "GridColor";
			// 
			// GridColorSelectionButton
			// 
			this.GridColorSelectionButton.Location = new System.Drawing.Point(109, 52);
			this.GridColorSelectionButton.Name = "GridColorSelectionButton";
			this.GridColorSelectionButton.Size = new System.Drawing.Size(14, 23);
			this.GridColorSelectionButton.TabIndex = 4;
			this.GridColorSelectionButton.Text = ">";
			this.GridColorSelectionButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.GridColorSelectionButton.UseVisualStyleBackColor = true;
			this.GridColorSelectionButton.Click += new System.EventHandler(this.GridColorSelectionButton_Click);
			// 
			// GridColorSelectionDisplay
			// 
			this.GridColorSelectionDisplay.Enabled = false;
			this.GridColorSelectionDisplay.Location = new System.Drawing.Point(129, 52);
			this.GridColorSelectionDisplay.Name = "GridColorSelectionDisplay";
			this.GridColorSelectionDisplay.Size = new System.Drawing.Size(20, 20);
			this.GridColorSelectionDisplay.TabIndex = 5;
			// 
			// LiveColorLabel
			// 
			this.LiveColorLabel.AutoSize = true;
			this.LiveColorLabel.Location = new System.Drawing.Point(53, 78);
			this.LiveColorLabel.Name = "LiveColorLabel";
			this.LiveColorLabel.Size = new System.Drawing.Size(51, 13);
			this.LiveColorLabel.TabIndex = 6;
			this.LiveColorLabel.Text = "LiveColor";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(110, 81);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(14, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = ">";
			this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// LiveColorSelectionDisplay
			// 
			this.LiveColorSelectionDisplay.Enabled = false;
			this.LiveColorSelectionDisplay.Location = new System.Drawing.Point(130, 81);
			this.LiveColorSelectionDisplay.Name = "LiveColorSelectionDisplay";
			this.LiveColorSelectionDisplay.Size = new System.Drawing.Size(20, 20);
			this.LiveColorSelectionDisplay.TabIndex = 8;
			// 
			// DeathColorLabel
			// 
			this.DeathColorLabel.AutoSize = true;
			this.DeathColorLabel.Location = new System.Drawing.Point(53, 107);
			this.DeathColorLabel.Name = "DeathColorLabel";
			this.DeathColorLabel.Size = new System.Drawing.Size(60, 13);
			this.DeathColorLabel.TabIndex = 9;
			this.DeathColorLabel.Text = "DeathColor";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(119, 110);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(14, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = ">";
			this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// DeathColorSelectionDisplay
			// 
			this.DeathColorSelectionDisplay.Enabled = false;
			this.DeathColorSelectionDisplay.Location = new System.Drawing.Point(139, 110);
			this.DeathColorSelectionDisplay.Name = "DeathColorSelectionDisplay";
			this.DeathColorSelectionDisplay.Size = new System.Drawing.Size(20, 20);
			this.DeathColorSelectionDisplay.TabIndex = 11;
			// 
			// CellColorDialog
			// 
			this.CellColorDialog.AnyColor = true;
			this.CellColorDialog.FullOpen = true;
			this.CellColorDialog.SolidColorOnly = true;
			// 
			// CustomizeDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(214, 157);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "CustomizeDialog";
			this.Text = "CustomizeDialog";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label CellColorLabel;
		private System.Windows.Forms.ColorDialog CellColorDialog;
		private System.Windows.Forms.TextBox CellColorSelectionDisplay;
		private System.Windows.Forms.Button CellColorSelectButton;
		private System.Windows.Forms.Label GridColorLabel;
		private System.Windows.Forms.Button GridColorSelectionButton;
		private System.Windows.Forms.TextBox GridColorSelectionDisplay;
		private System.Windows.Forms.ColorDialog GridColorDialog;
		private System.Windows.Forms.Label LiveColorLabel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox LiveColorSelectionDisplay;
		private System.Windows.Forms.Label DeathColorLabel;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox DeathColorSelectionDisplay;
		private System.Windows.Forms.ColorDialog LiveColorDialog;
		private System.Windows.Forms.ColorDialog DeathColorDialog;
	}
}