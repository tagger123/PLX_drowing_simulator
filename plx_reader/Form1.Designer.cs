namespace plx_reader
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			button1 = new Button();
			fileSystemWatcher1 = new FileSystemWatcher();
			((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.AllowDrop = true;
			textBox1.Location = new Point(12, 27);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(665, 23);
			textBox1.TabIndex = 0;
			textBox1.DragDrop += textBox_DragDrop;
			textBox1.DragEnter += textBox_DragEnter;
			// 
			// button1
			// 
			button1.Location = new Point(683, 26);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 2;
			button1.Text = "Open";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// fileSystemWatcher1
			// 
			fileSystemWatcher1.EnableRaisingEvents = true;
			fileSystemWatcher1.SynchronizingObject = this;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			ClientSize = new Size(766, 80);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox textBox1;
		private Button button1;
		private FileSystemWatcher fileSystemWatcher1;
	}
}
