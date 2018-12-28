namespace LissajousTable.ui
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.nud_speed_x = new System.Windows.Forms.NumericUpDown();
			this.nud_speed_y = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nud_speed_x)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_speed_y)).BeginInit();
			this.SuspendLayout();
			// 
			// nud_speed_x
			// 
			this.nud_speed_x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nud_speed_x.DecimalPlaces = 1;
			this.nud_speed_x.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.nud_speed_x.Location = new System.Drawing.Point(1132, 12);
			this.nud_speed_x.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nud_speed_x.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.nud_speed_x.Name = "nud_speed_x";
			this.nud_speed_x.Size = new System.Drawing.Size(120, 26);
			this.nud_speed_x.TabIndex = 0;
			this.nud_speed_x.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// nud_speed_y
			// 
			this.nud_speed_y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nud_speed_y.DecimalPlaces = 1;
			this.nud_speed_y.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.nud_speed_y.Location = new System.Drawing.Point(1132, 53);
			this.nud_speed_y.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nud_speed_y.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.nud_speed_y.Name = "nud_speed_y";
			this.nud_speed_y.Size = new System.Drawing.Size(120, 26);
			this.nud_speed_y.TabIndex = 1;
			this.nud_speed_y.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(1051, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Speed X:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(1051, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Speed Y:";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(106F, 106F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1264, 679);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nud_speed_y);
			this.Controls.Add(this.nud_speed_x);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "FormMain";
			this.Text = "LissajousTable";
			((System.ComponentModel.ISupportInitialize)(this.nud_speed_x)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_speed_y)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nud_speed_x;
		private System.Windows.Forms.NumericUpDown nud_speed_y;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

