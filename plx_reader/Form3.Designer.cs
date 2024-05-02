namespace plx_reader
{
	partial class Form3
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
			panel1 = new Panel();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.AutoScroll = true;
			panel1.AutoScrollMinSize = new Size(50, 50);
			panel1.AutoSize = true;
			panel1.Location = new Point(12, 4);
			panel1.MinimumSize = new Size(250, 500);
			panel1.Name = "panel1";
			panel1.Size = new Size(250, 500);
			panel1.TabIndex = 0;
			panel1.Paint += panel1_Paint;
			// 
			// Form3
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			AutoScrollMinSize = new Size(50, 50);
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ClientSize = new Size(289, 450);
			Controls.Add(panel1);
			Name = "Form3";
			Text = "Form3";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
	}
}