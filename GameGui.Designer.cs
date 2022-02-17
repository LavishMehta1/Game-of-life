
namespace Lab4GameOfLife
{
    partial class GameGui
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
            this.components = new System.ComponentModel.Container();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.genTextBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioColorGreen = new System.Windows.Forms.RadioButton();
            this.radioColorBlue = new System.Windows.Forms.RadioButton();
            this.radioColorRed = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.controlsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Location = new System.Drawing.Point(12, 124);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(450, 450);
            this.mainGroupBox.TabIndex = 0;
            this.mainGroupBox.TabStop = false;
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.label1);
            this.controlsGroupBox.Controls.Add(this.resetButton);
            this.controlsGroupBox.Controls.Add(this.pauseButton);
            this.controlsGroupBox.Controls.Add(this.startButton);
            this.controlsGroupBox.Controls.Add(this.genTextBox);
            this.controlsGroupBox.Location = new System.Drawing.Point(12, 4);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(450, 58);
            this.controlsGroupBox.TabIndex = 1;
            this.controlsGroupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Generation Number:";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(200, 22);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(91, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(104, 22);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(90, 23);
            this.pauseButton.TabIndex = 2;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(6, 22);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(92, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // genTextBox
            // 
            this.genTextBox.BackColor = System.Drawing.Color.White;
            this.genTextBox.ForeColor = System.Drawing.Color.Gray;
            this.genTextBox.Location = new System.Drawing.Point(320, 29);
            this.genTextBox.Name = "genTextBox";
            this.genTextBox.Size = new System.Drawing.Size(100, 23);
            this.genTextBox.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioColorGreen);
            this.groupBox1.Controls.Add(this.radioColorBlue);
            this.groupBox1.Controls.Add(this.radioColorRed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 58);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // radioColorGreen
            // 
            this.radioColorGreen.AutoSize = true;
            this.radioColorGreen.ForeColor = System.Drawing.Color.Green;
            this.radioColorGreen.Location = new System.Drawing.Point(183, 24);
            this.radioColorGreen.Name = "radioColorGreen";
            this.radioColorGreen.Size = new System.Drawing.Size(56, 19);
            this.radioColorGreen.TabIndex = 7;
            this.radioColorGreen.Text = "Green";
            this.radioColorGreen.UseVisualStyleBackColor = true;
            this.radioColorGreen.CheckedChanged += new System.EventHandler(this.radioColorGreen_CheckedChanged);
            // 
            // radioColorBlue
            // 
            this.radioColorBlue.AutoSize = true;
            this.radioColorBlue.ForeColor = System.Drawing.Color.Blue;
            this.radioColorBlue.Location = new System.Drawing.Point(243, 24);
            this.radioColorBlue.Name = "radioColorBlue";
            this.radioColorBlue.Size = new System.Drawing.Size(48, 19);
            this.radioColorBlue.TabIndex = 6;
            this.radioColorBlue.Text = "Blue";
            this.radioColorBlue.UseVisualStyleBackColor = true;
            this.radioColorBlue.CheckedChanged += new System.EventHandler(this.radioColorBlue_CheckedChanged);
            // 
            // radioColorRed
            // 
            this.radioColorRed.AutoSize = true;
            this.radioColorRed.Checked = true;
            this.radioColorRed.ForeColor = System.Drawing.Color.Red;
            this.radioColorRed.Location = new System.Drawing.Point(134, 24);
            this.radioColorRed.Name = "radioColorRed";
            this.radioColorRed.Size = new System.Drawing.Size(45, 19);
            this.radioColorRed.TabIndex = 5;
            this.radioColorRed.TabStop = true;
            this.radioColorRed.Text = "Red";
            this.radioColorRed.UseVisualStyleBackColor = true;
            this.radioColorRed.CheckedChanged += new System.EventHandler(this.radioColorRed_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cell Colour Selection:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(320, 22);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save Image";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // GameGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 586);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.controlsGroupBox);
            this.Controls.Add(this.mainGroupBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 625);
            this.MinimumSize = new System.Drawing.Size(490, 625);
            this.Name = "GameGui";
            this.Text = "PRG455 - Game of Life";
            this.Load += new System.EventHandler(this.GameGui_Load);
            this.controlsGroupBox.ResumeLayout(false);
            this.controlsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.TextBox genTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioColorGreen;
        private System.Windows.Forms.RadioButton radioColorBlue;
        private System.Windows.Forms.RadioButton radioColorRed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
    }
}

