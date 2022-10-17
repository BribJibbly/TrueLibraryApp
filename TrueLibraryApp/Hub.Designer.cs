
namespace TrueLibraryApp
{
    partial class Hub
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Help1 = new System.Windows.Forms.Button();
            this.Help2 = new System.Windows.Forms.Button();
            this.Help3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Replacing Books";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.Location = new System.Drawing.Point(44, 94);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Identifying Areas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Location = new System.Drawing.Point(44, 166);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Finding Call Numbers";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Help1
            // 
            this.Help1.Cursor = System.Windows.Forms.Cursors.Help;
            this.Help1.Location = new System.Drawing.Point(240, 36);
            this.Help1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Help1.Name = "Help1";
            this.Help1.Size = new System.Drawing.Size(20, 23);
            this.Help1.TabIndex = 3;
            this.Help1.Text = "?";
            this.Help1.UseVisualStyleBackColor = true;
            // 
            // Help2
            // 
            this.Help2.Cursor = System.Windows.Forms.Cursors.Help;
            this.Help2.Location = new System.Drawing.Point(240, 104);
            this.Help2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Help2.Name = "Help2";
            this.Help2.Size = new System.Drawing.Size(20, 23);
            this.Help2.TabIndex = 4;
            this.Help2.Text = "?";
            this.Help2.UseVisualStyleBackColor = true;
            // 
            // Help3
            // 
            this.Help3.Cursor = System.Windows.Forms.Cursors.Help;
            this.Help3.Location = new System.Drawing.Point(240, 176);
            this.Help3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Help3.Name = "Help3";
            this.Help3.Size = new System.Drawing.Size(20, 23);
            this.Help3.TabIndex = 5;
            this.Help3.Text = "?";
            this.Help3.UseVisualStyleBackColor = true;
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(286, 244);
            this.Controls.Add(this.Help3);
            this.Controls.Add(this.Help2);
            this.Controls.Add(this.Help1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Hub";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Help1;
        private System.Windows.Forms.Button Help2;
        private System.Windows.Forms.Button Help3;
    }
}

