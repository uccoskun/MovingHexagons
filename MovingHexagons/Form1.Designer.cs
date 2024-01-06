
namespace MovingHexagons
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new MovingHexagons.TransparentPanel();
            this.panel2 = new MovingHexagons.TransparentPanel();
            this.panel3 = new MovingHexagons.TransparentPanel();
            this.panel4 = new MovingHexagons.TransparentPanel();
            this.panel5 = new MovingHexagons.TransparentPanel();
            this.panel6 = new MovingHexagons.TransparentPanel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 184);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 184);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(228, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 184);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(470, 239);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 184);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(240, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(210, 184);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(470, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(210, 184);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer2;
        private TransparentPanel panel1;
        private TransparentPanel panel2;
        private TransparentPanel panel3;
        private TransparentPanel panel4;
        private TransparentPanel panel5;
        private TransparentPanel panel6;
    }
}

