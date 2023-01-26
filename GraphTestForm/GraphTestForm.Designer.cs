namespace GraphTestForm
{
    partial class GraphTestForm
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
            this.testSimpleBarsGraphControl = new SimpleBarsGraph.SimpleBarsGraphControl();
            this.addGraphValueTimer = new System.Windows.Forms.Timer(this.components);
            this.speedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testSimpleBarsGraphControl
            // 
            this.testSimpleBarsGraphControl.Location = new System.Drawing.Point(152, 19);
            this.testSimpleBarsGraphControl.Name = "testSimpleBarsGraphControl";
            this.testSimpleBarsGraphControl.Scalable = true;
            this.testSimpleBarsGraphControl.Size = new System.Drawing.Size(128, 25);
            this.testSimpleBarsGraphControl.TabIndex = 0;
            // 
            // addGraphValueTimer
            // 
            this.addGraphValueTimer.Enabled = true;
            this.addGraphValueTimer.Interval = 1000;
            this.addGraphValueTimer.Tick += new System.EventHandler(this.addGraphValueTimer_Tick);
            // 
            // speedLabel
            // 
            this.speedLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.speedLabel.Location = new System.Drawing.Point(24, 25);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(120, 15);
            this.speedLabel.TabIndex = 1;
            this.speedLabel.Text = "n/a";
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GraphTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 92);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.testSimpleBarsGraphControl);
            this.Name = "GraphTestForm";
            this.Text = "GraphTestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleBarsGraph.SimpleBarsGraphControl testSimpleBarsGraphControl;
        private System.Windows.Forms.Timer addGraphValueTimer;
        private Label speedLabel;
    }
}