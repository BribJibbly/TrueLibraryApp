namespace TrueLibraryApp
{
    partial class FindingCallNumbersForm
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
            this.components = new System.ComponentModel.Container();
            this.ansBtn1 = new System.Windows.Forms.Button();
            this.ansBtn2 = new System.Windows.Forms.Button();
            this.ansBtn3 = new System.Windows.Forms.Button();
            this.ansBtn4 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.quesLbl = new System.Windows.Forms.Label();
            this.lvlLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ansBtn1
            // 
            this.ansBtn1.Location = new System.Drawing.Point(92, 129);
            this.ansBtn1.Name = "ansBtn1";
            this.ansBtn1.Size = new System.Drawing.Size(266, 73);
            this.ansBtn1.TabIndex = 0;
            this.ansBtn1.Text = "button1";
            this.ansBtn1.UseVisualStyleBackColor = true;
            this.ansBtn1.Click += new System.EventHandler(this.ansBtn1_Click);
            // 
            // ansBtn2
            // 
            this.ansBtn2.Location = new System.Drawing.Point(441, 129);
            this.ansBtn2.Name = "ansBtn2";
            this.ansBtn2.Size = new System.Drawing.Size(266, 73);
            this.ansBtn2.TabIndex = 1;
            this.ansBtn2.Text = "button2";
            this.ansBtn2.UseVisualStyleBackColor = true;
            this.ansBtn2.Click += new System.EventHandler(this.ansBtn2_Click);
            // 
            // ansBtn3
            // 
            this.ansBtn3.Location = new System.Drawing.Point(92, 250);
            this.ansBtn3.Name = "ansBtn3";
            this.ansBtn3.Size = new System.Drawing.Size(266, 73);
            this.ansBtn3.TabIndex = 2;
            this.ansBtn3.Text = "button3";
            this.ansBtn3.UseVisualStyleBackColor = true;
            this.ansBtn3.Click += new System.EventHandler(this.ansBtn3_Click);
            // 
            // ansBtn4
            // 
            this.ansBtn4.Location = new System.Drawing.Point(441, 250);
            this.ansBtn4.Name = "ansBtn4";
            this.ansBtn4.Size = new System.Drawing.Size(266, 73);
            this.ansBtn4.TabIndex = 3;
            this.ansBtn4.Text = "button4";
            this.ansBtn4.UseVisualStyleBackColor = true;
            this.ansBtn4.Click += new System.EventHandler(this.ansBtn4_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 364);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // quesLbl
            // 
            this.quesLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quesLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quesLbl.Location = new System.Drawing.Point(-1, 63);
            this.quesLbl.Name = "quesLbl";
            this.quesLbl.Size = new System.Drawing.Size(802, 25);
            this.quesLbl.TabIndex = 5;
            this.quesLbl.Text = "label1";
            this.quesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvlLbl
            // 
            this.lvlLbl.AutoSize = true;
            this.lvlLbl.Location = new System.Drawing.Point(12, 9);
            this.lvlLbl.Name = "lvlLbl";
            this.lvlLbl.Size = new System.Drawing.Size(86, 15);
            this.lvlLbl.TabIndex = 6;
            this.lvlLbl.Text = "Current level: 1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(722, 9);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(13, 15);
            this.time.TabIndex = 7;
            this.time.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(680, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Time:";
            // 
            // FindingCallNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.lvlLbl);
            this.Controls.Add(this.quesLbl);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ansBtn4);
            this.Controls.Add(this.ansBtn3);
            this.Controls.Add(this.ansBtn2);
            this.Controls.Add(this.ansBtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FindingCallNumbersForm";
            this.Text = "FindingCallNumbersForm";
            this.Load += new System.EventHandler(this.FindingCallNumbersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ansBtn1;
        private System.Windows.Forms.Button ansBtn2;
        private System.Windows.Forms.Button ansBtn3;
        private System.Windows.Forms.Button ansBtn4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label quesLbl;
        private System.Windows.Forms.Label lvlLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label1;
    }
}