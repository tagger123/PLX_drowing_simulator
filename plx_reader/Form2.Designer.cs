namespace plx_reader
{
	partial class Form2
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
			panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			panel1.Location = new Point(12, 25);
			panel1.Name = "panel1";
			panel1.Size = new Size(780, 575);
			panel1.TabIndex = 0;
			panel1.Paint += panel1_Paint_1;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			AutoScrollMinSize = new Size(50, 50);
			ClientSize = new Size(806, 612);
			Controls.Add(panel1);
			Name = "Form2";
			Text = "Form2";
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
	}
}