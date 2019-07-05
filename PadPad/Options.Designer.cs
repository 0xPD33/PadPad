namespace PadPad
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lightModeCheckBox1 = new System.Windows.Forms.CheckBox();
            this.ApplyButton1 = new System.Windows.Forms.Button();
            this.ConfirmButton1 = new System.Windows.Forms.Button();
            this.CancelButton1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lightModeCheckBox1);
            this.panel1.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 292);
            this.panel1.TabIndex = 0;
            // 
            // lightModeCheckBox1
            // 
            this.lightModeCheckBox1.AutoSize = true;
            this.lightModeCheckBox1.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightModeCheckBox1.Location = new System.Drawing.Point(3, 3);
            this.lightModeCheckBox1.Name = "lightModeCheckBox1";
            this.lightModeCheckBox1.Size = new System.Drawing.Size(86, 18);
            this.lightModeCheckBox1.TabIndex = 0;
            this.lightModeCheckBox1.Text = "Light Mode";
            this.lightModeCheckBox1.UseVisualStyleBackColor = true;
            this.lightModeCheckBox1.CheckedChanged += new System.EventHandler(this.lightModeCheckBox1_CheckedChanged);
            // 
            // ApplyButton1
            // 
            this.ApplyButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ApplyButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyButton1.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.ApplyButton1.Location = new System.Drawing.Point(15, 310);
            this.ApplyButton1.Name = "ApplyButton1";
            this.ApplyButton1.Size = new System.Drawing.Size(86, 27);
            this.ApplyButton1.TabIndex = 1;
            this.ApplyButton1.Text = "Apply";
            this.ApplyButton1.UseVisualStyleBackColor = false;
            this.ApplyButton1.Click += new System.EventHandler(this.ApplyButton1_Click);
            // 
            // ConfirmButton1
            // 
            this.ConfirmButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ConfirmButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton1.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.ConfirmButton1.Location = new System.Drawing.Point(116, 310);
            this.ConfirmButton1.Name = "ConfirmButton1";
            this.ConfirmButton1.Size = new System.Drawing.Size(86, 27);
            this.ConfirmButton1.TabIndex = 2;
            this.ConfirmButton1.Text = "Confirm";
            this.ConfirmButton1.UseVisualStyleBackColor = false;
            this.ConfirmButton1.Click += new System.EventHandler(this.ConfirmButton1_Click);
            // 
            // CancelButton1
            // 
            this.CancelButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CancelButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton1.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.CancelButton1.Location = new System.Drawing.Point(334, 310);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(86, 27);
            this.CancelButton1.TabIndex = 3;
            this.CancelButton1.Text = "Cancel";
            this.CancelButton1.UseVisualStyleBackColor = false;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton1_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(432, 349);
            this.Controls.Add(this.CancelButton1);
            this.Controls.Add(this.ConfirmButton1);
            this.Controls.Add(this.ApplyButton1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox lightModeCheckBox1;
        private System.Windows.Forms.Button ApplyButton1;
        private System.Windows.Forms.Button ConfirmButton1;
        private System.Windows.Forms.Button CancelButton1;
    }
}