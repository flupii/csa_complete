namespace RobotView
{
    partial class RunArc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonArcNeg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonArcRight = new System.Windows.Forms.RadioButton();
            this.upDownArcAngle = new System.Windows.Forms.NumericUpDown();
            this.arcLeftRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.upDownArcRadius = new System.Windows.Forms.NumericUpDown();
            this.buttonStartArc = new System.Windows.Forms.Button();
            this.buttonEditRadius = new System.Windows.Forms.Button();
            this.buttonEditAngle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonArcNeg
            // 
            this.buttonArcNeg.Location = new System.Drawing.Point(174, 62);
            this.buttonArcNeg.Name = "buttonArcNeg";
            this.buttonArcNeg.Size = new System.Drawing.Size(35, 24);
            this.buttonArcNeg.TabIndex = 24;
            this.buttonArcNeg.Text = "+/ -";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.Text = "RunArc";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.Text = "Angle (+/- degrees)";
            // 
            // radioButtonArcRight
            // 
            this.radioButtonArcRight.Location = new System.Drawing.Point(272, 4);
            this.radioButtonArcRight.Name = "radioButtonArcRight";
            this.radioButtonArcRight.Size = new System.Drawing.Size(61, 20);
            this.radioButtonArcRight.TabIndex = 29;
            this.radioButtonArcRight.TabStop = false;
            this.radioButtonArcRight.Text = "Right";
            // 
            // upDownArcAngle
            // 
            this.upDownArcAngle.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.upDownArcAngle.Location = new System.Drawing.Point(215, 62);
            this.upDownArcAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.upDownArcAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.upDownArcAngle.Name = "upDownArcAngle";
            this.upDownArcAngle.Size = new System.Drawing.Size(75, 24);
            this.upDownArcAngle.TabIndex = 27;
            this.upDownArcAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // arcLeftRadioButton
            // 
            this.arcLeftRadioButton.Checked = true;
            this.arcLeftRadioButton.Location = new System.Drawing.Point(215, 4);
            this.arcLeftRadioButton.Name = "arcLeftRadioButton";
            this.arcLeftRadioButton.Size = new System.Drawing.Size(51, 20);
            this.arcLeftRadioButton.TabIndex = 30;
            this.arcLeftRadioButton.Text = "Left";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(3, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.Text = "Radius (+ mm)";
            // 
            // upDownArcRadius
            // 
            this.upDownArcRadius.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.upDownArcRadius.Location = new System.Drawing.Point(215, 30);
            this.upDownArcRadius.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.upDownArcRadius.Name = "upDownArcRadius";
            this.upDownArcRadius.Size = new System.Drawing.Size(75, 24);
            this.upDownArcRadius.TabIndex = 28;
            this.upDownArcRadius.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // buttonStartArc
            // 
            this.buttonStartArc.Location = new System.Drawing.Point(353, 30);
            this.buttonStartArc.Name = "buttonStartArc";
            this.buttonStartArc.Size = new System.Drawing.Size(51, 57);
            this.buttonStartArc.TabIndex = 23;
            this.buttonStartArc.Text = "Start";
            this.buttonStartArc.Click += new System.EventHandler(this.buttonStartArc_Click);
            // 
            // buttonEditRadius
            // 
            this.buttonEditRadius.Location = new System.Drawing.Point(296, 30);
            this.buttonEditRadius.Name = "buttonEditRadius";
            this.buttonEditRadius.Size = new System.Drawing.Size(51, 24);
            this.buttonEditRadius.TabIndex = 32;
            this.buttonEditRadius.Text = "...";
            this.buttonEditRadius.Click += new System.EventHandler(this.buttonEditRadius_Click);
            // 
            // buttonEditAngle
            // 
            this.buttonEditAngle.Location = new System.Drawing.Point(296, 63);
            this.buttonEditAngle.Name = "buttonEditAngle";
            this.buttonEditAngle.Size = new System.Drawing.Size(51, 24);
            this.buttonEditAngle.TabIndex = 33;
            this.buttonEditAngle.Text = "...";
            this.buttonEditAngle.Click += new System.EventHandler(this.buttonEditAngle_Click);
            // 
            // RunArc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.buttonEditAngle);
            this.Controls.Add(this.buttonEditRadius);
            this.Controls.Add(this.buttonArcNeg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonArcRight);
            this.Controls.Add(this.upDownArcAngle);
            this.Controls.Add(this.arcLeftRadioButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.upDownArcRadius);
            this.Controls.Add(this.buttonStartArc);
            this.Name = "RunArc";
            this.Size = new System.Drawing.Size(410, 90);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonArcNeg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonArcRight;
        private System.Windows.Forms.NumericUpDown upDownArcAngle;
        private System.Windows.Forms.RadioButton arcLeftRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown upDownArcRadius;
        private System.Windows.Forms.Button buttonStartArc;
        private System.Windows.Forms.Button buttonEditRadius;
        private System.Windows.Forms.Button buttonEditAngle;
    }
}
