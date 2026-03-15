namespace RsrcCleanup
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnDispAndRel = new System.Windows.Forms.Button();
            this.btnCollect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(44, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.OnAdd);
            // 
            // btnRelease
            // 
            this.btnRelease.Location = new System.Drawing.Point(139, 103);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(75, 23);
            this.btnRelease.TabIndex = 1;
            this.btnRelease.Text = "&Release";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.OnRelease);
            // 
            // btnDispAndRel
            // 
            this.btnDispAndRel.Location = new System.Drawing.Point(234, 103);
            this.btnDispAndRel.Name = "btnDispAndRel";
            this.btnDispAndRel.Size = new System.Drawing.Size(131, 23);
            this.btnDispAndRel.TabIndex = 2;
            this.btnDispAndRel.Text = "&Dispose and Release";
            this.btnDispAndRel.UseVisualStyleBackColor = true;
            this.btnDispAndRel.Click += new System.EventHandler(this.OnDisposeAndRelease);
            // 
            // btnCollect
            // 
            this.btnCollect.Location = new System.Drawing.Point(385, 103);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(75, 23);
            this.btnCollect.TabIndex = 3;
            this.btnCollect.Text = "&Collect";
            this.btnCollect.UseVisualStyleBackColor = true;
            this.btnCollect.Click += new System.EventHandler(this.OnCollect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 219);
            this.Controls.Add(this.btnCollect);
            this.Controls.Add(this.btnDispAndRel);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Resource Cleanup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Button btnDispAndRel;
        private System.Windows.Forms.Button btnCollect;
    }
}

