
namespace Christmas
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonSelectCar = new System.Windows.Forms.Button();
            this.buttonSelectBall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.buttonSelectBall);
            this.mainPanel.Controls.Add(this.buttonSelectCar);
            this.mainPanel.Location = new System.Drawing.Point(5, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(783, 434);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // buttonSelectCar
            // 
            this.buttonSelectCar.Location = new System.Drawing.Point(199, 282);
            this.buttonSelectCar.Name = "buttonSelectCar";
            this.buttonSelectCar.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectCar.TabIndex = 0;
            this.buttonSelectCar.Text = "buttonSelectCar";
            this.buttonSelectCar.UseVisualStyleBackColor = true;
            this.buttonSelectCar.Click += new System.EventHandler(this.buttonSelectCar_Click);
            // 
            // buttonSelectBall
            // 
            this.buttonSelectBall.Location = new System.Drawing.Point(423, 282);
            this.buttonSelectBall.Name = "buttonSelectBall";
            this.buttonSelectBall.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectBall.TabIndex = 1;
            this.buttonSelectBall.Text = "button2";
            this.buttonSelectBall.UseVisualStyleBackColor = true;
            this.buttonSelectBall.Click += new System.EventHandler(this.buttonSelectBall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coming next";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelectBall;
        private System.Windows.Forms.Button buttonSelectCar;
    }
}

