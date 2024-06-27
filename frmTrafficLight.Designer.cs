namespace TrafficLight
{
    partial class frmTrafficLight
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
            this.ctrlTrafficLight2 = new TrafficLight.ctrlTrafficLight();
            this.ctrlTrafficLight1 = new TrafficLight.ctrlTrafficLight();
            this.SuspendLayout();
            // 
            // ctrlTrafficLight2
            // 
            this.ctrlTrafficLight2.CurrentLight = TrafficLight.ctrlTrafficLight.enTrafficLight.Yellow;
            this.ctrlTrafficLight2.GreenTime = 3;
            this.ctrlTrafficLight2.Location = new System.Drawing.Point(303, 66);
            this.ctrlTrafficLight2.Name = "ctrlTrafficLight2";
            this.ctrlTrafficLight2.RedTime = 5;
            this.ctrlTrafficLight2.Size = new System.Drawing.Size(142, 201);
            this.ctrlTrafficLight2.TabIndex = 1;
            this.ctrlTrafficLight2.YellowTime = 5;
            // 
            // ctrlTrafficLight1
            // 
            this.ctrlTrafficLight1.CurrentLight = TrafficLight.ctrlTrafficLight.enTrafficLight.Red;
            this.ctrlTrafficLight1.GreenTime = 3;
            this.ctrlTrafficLight1.Location = new System.Drawing.Point(28, 30);
            this.ctrlTrafficLight1.Name = "ctrlTrafficLight1";
            this.ctrlTrafficLight1.RedTime = 10;
            this.ctrlTrafficLight1.Size = new System.Drawing.Size(179, 250);
            this.ctrlTrafficLight1.TabIndex = 0;
            this.ctrlTrafficLight1.YellowTime = 5;
            this.ctrlTrafficLight1.RedOn += new System.EventHandler<TrafficLight.ctrlTrafficLight.OnTrafficColorChangeEventArgs>(this.ctrlTrafficLight1_RedOn);
            // 
            // frmTrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 439);
            this.Controls.Add(this.ctrlTrafficLight2);
            this.Controls.Add(this.ctrlTrafficLight1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTrafficLight";
            this.Text = "Traffic Light";
            this.Load += new System.EventHandler(this.frmTrafficLight_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTrafficLight ctrlTrafficLight1;
        private ctrlTrafficLight ctrlTrafficLight2;
    }
}