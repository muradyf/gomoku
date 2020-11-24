namespace Gomoku
{
    partial class GForm
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
            this.Panel = new System.Windows.Forms.Panel();
            this.Start = new System.Windows.Forms.Button();
            this.Fivex5 = new System.Windows.Forms.RadioButton();
            this.Tenx10 = new System.Windows.Forms.RadioButton();
            this.Fifteenx15 = new System.Windows.Forms.RadioButton();
            this.Gamemode = new System.Windows.Forms.Panel();
            this.HumanVsHuman = new System.Windows.Forms.RadioButton();
            this.HumanVsMachine = new System.Windows.Forms.RadioButton();
            this.Grid = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel.SuspendLayout();
            this.Gamemode.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.Controls.Add(this.Fivex5);
            this.Panel.Controls.Add(this.Tenx10);
            this.Panel.Controls.Add(this.Fifteenx15);
            this.Panel.Controls.Add(this.Gamemode);
            this.Panel.Location = new System.Drawing.Point(12, 12);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(500, 75);
            this.Panel.TabIndex = 0;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(176, 0);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(135, 31);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Fivex5
            // 
            this.Fivex5.AutoSize = true;
            this.Fivex5.Location = new System.Drawing.Point(63, 15);
            this.Fivex5.Name = "Fivex5";
            this.Fivex5.Size = new System.Drawing.Size(42, 17);
            this.Fivex5.TabIndex = 0;
            this.Fivex5.TabStop = true;
            this.Fivex5.Text = "5x5";
            this.Fivex5.UseVisualStyleBackColor = true;
            this.Fivex5.CheckedChanged += new System.EventHandler(this.Fivex5_CheckedChanged);
            // 
            // Tenx10
            // 
            this.Tenx10.AutoSize = true;
            this.Tenx10.Location = new System.Drawing.Point(224, 15);
            this.Tenx10.Name = "Tenx10";
            this.Tenx10.Size = new System.Drawing.Size(54, 17);
            this.Tenx10.TabIndex = 1;
            this.Tenx10.TabStop = true;
            this.Tenx10.Text = "10x10";
            this.Tenx10.UseVisualStyleBackColor = true;
            this.Tenx10.CheckedChanged += new System.EventHandler(this.Tenx10_CheckedChanged);
            // 
            // Fifteenx15
            // 
            this.Fifteenx15.AutoSize = true;
            this.Fifteenx15.Location = new System.Drawing.Point(379, 15);
            this.Fifteenx15.Name = "Fifteenx15";
            this.Fifteenx15.Size = new System.Drawing.Size(54, 17);
            this.Fifteenx15.TabIndex = 2;
            this.Fifteenx15.TabStop = true;
            this.Fifteenx15.Text = "15x15";
            this.Fifteenx15.UseVisualStyleBackColor = true;
            this.Fifteenx15.CheckedChanged += new System.EventHandler(this.Fifteenx15_CheckedChanged_1);
            // 
            // Gamemode
            // 
            this.Gamemode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gamemode.Controls.Add(this.Start);
            this.Gamemode.Controls.Add(this.HumanVsHuman);
            this.Gamemode.Controls.Add(this.HumanVsMachine);
            this.Gamemode.Location = new System.Drawing.Point(3, 42);
            this.Gamemode.Name = "Gamemode";
            this.Gamemode.Size = new System.Drawing.Size(494, 30);
            this.Gamemode.TabIndex = 4;
            this.Gamemode.Paint += new System.Windows.Forms.PaintEventHandler(this.Gamemode_Paint);
            // 
            // HumanVsHuman
            // 
            this.HumanVsHuman.AutoSize = true;
            this.HumanVsHuman.Location = new System.Drawing.Point(29, 8);
            this.HumanVsHuman.Name = "HumanVsHuman";
            this.HumanVsHuman.Size = new System.Drawing.Size(110, 17);
            this.HumanVsHuman.TabIndex = 6;
            this.HumanVsHuman.TabStop = true;
            this.HumanVsHuman.Text = "Human vs Human";
            this.HumanVsHuman.UseVisualStyleBackColor = true;
            this.HumanVsHuman.CheckedChanged += new System.EventHandler(this.HumanVsHuman_CheckedChanged);
            // 
            // HumanVsMachine
            // 
            this.HumanVsMachine.AutoSize = true;
            this.HumanVsMachine.Location = new System.Drawing.Point(348, 8);
            this.HumanVsMachine.Name = "HumanVsMachine";
            this.HumanVsMachine.Size = new System.Drawing.Size(117, 17);
            this.HumanVsMachine.TabIndex = 6;
            this.HumanVsMachine.TabStop = true;
            this.HumanVsMachine.Text = "Human vs Machine";
            this.HumanVsMachine.UseVisualStyleBackColor = true;
            this.HumanVsMachine.CheckedChanged += new System.EventHandler(this.HumanVsMachine_CheckedChanged);
            // 
            // Grid
            // 
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.Location = new System.Drawing.Point(22, 110);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(500, 500);
            this.Grid.TabIndex = 1;
            this.Grid.Paint += new System.Windows.Forms.PaintEventHandler(this.Grid_Paint);
            // 
            // GForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 610);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.Panel);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "GForm";
            this.Text = "Gomoku";
            this.Load += new System.EventHandler(this.GForm_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.Gamemode.ResumeLayout(false);
            this.Gamemode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.RadioButton Fivex5;
        private System.Windows.Forms.RadioButton Tenx10;
        private System.Windows.Forms.RadioButton Fifteenx15;
        private System.Windows.Forms.FlowLayoutPanel Grid;
        private System.Windows.Forms.Panel Gamemode;
        private System.Windows.Forms.RadioButton HumanVsMachine;
        private System.Windows.Forms.RadioButton HumanVsHuman;
    }
}

