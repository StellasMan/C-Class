namespace RsrcDispose
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
            this.btnAddRsrc = new System.Windows.Forms.Button();
            this.btnDisposeRsrcs = new System.Windows.Forms.Button();
            this.btnCollect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddRsrc
            // 
            this.btnAddRsrc.Location = new System.Drawing.Point(23, 71);
            this.btnAddRsrc.Name = "btnAddRsrc";
            this.btnAddRsrc.Size = new System.Drawing.Size(122, 23);
            this.btnAddRsrc.TabIndex = 0;
            this.btnAddRsrc.Text = "&Add Resource";
            this.btnAddRsrc.UseVisualStyleBackColor = true;
            this.btnAddRsrc.Click += new System.EventHandler(this.OnAddResource);
            // 
            // btnDisposeRsrcs
            // 
            this.btnDisposeRsrcs.Location = new System.Drawing.Point(163, 71);
            this.btnDisposeRsrcs.Name = "btnDisposeRsrcs";
            this.btnDisposeRsrcs.Size = new System.Drawing.Size(122, 23);
            this.btnDisposeRsrcs.TabIndex = 1;
            this.btnDisposeRsrcs.Text = "&Dispose Resources";
            this.btnDisposeRsrcs.UseVisualStyleBackColor = true;
            this.btnDisposeRsrcs.Click += new System.EventHandler(this.OnDisposeResource);
            // 
            // btnCollect
            // 
            this.btnCollect.Location = new System.Drawing.Point(303, 71);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(122, 23);
            this.btnCollect.TabIndex = 2;
            this.btnCollect.Text = "&Collect";
            this.btnCollect.UseVisualStyleBackColor = true;
            this.btnCollect.Click += new System.EventHandler(this.OnCollect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 165);
            this.Controls.Add(this.btnCollect);
            this.Controls.Add(this.btnDisposeRsrcs);
            this.Controls.Add(this.btnAddRsrc);
            this.Name = "Form1";
            this.Text = "Resource Dispose";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddRsrc;
        private System.Windows.Forms.Button btnDisposeRsrcs;
        private System.Windows.Forms.Button btnCollect;
    }
}

