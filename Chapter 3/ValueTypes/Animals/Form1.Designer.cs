namespace Animals
{
	partial class AnimalsForm
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
			this.cmbAnimals = new System.Windows.Forms.ComboBox();
			this.btnGo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmbAnimals
			// 
			this.cmbAnimals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAnimals.FormattingEnabled = true;
			this.cmbAnimals.Location = new System.Drawing.Point(43, 40);
			this.cmbAnimals.Name = "cmbAnimals";
			this.cmbAnimals.Size = new System.Drawing.Size(177, 21);
			this.cmbAnimals.TabIndex = 0;
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(94, 101);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(75, 23);
			this.btnGo.TabIndex = 1;
			this.btnGo.Text = "&Go";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.OnGo);
			// 
			// AnimalsForm
			// 
			this.AcceptButton = this.btnGo;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(263, 168);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.cmbAnimals);
			this.Name = "AnimalsForm";
			this.Text = "Animals";
			this.Load += new System.EventHandler(this.OnLoad);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbAnimals;
		private System.Windows.Forms.Button btnGo;
	}
}

