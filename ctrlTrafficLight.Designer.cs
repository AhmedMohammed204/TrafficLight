namespace TrafficLight
{
    partial class ctrlTrafficLight
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
            this.components = new System.ComponentModel.Container();
            this.pbTrafficLight = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficLight)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTrafficLight
            // 
            this.pbTrafficLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTrafficLight.Image = global::TrafficLight.Properties.Resources.red_light_red;
            this.pbTrafficLight.Location = new System.Drawing.Point(0, 0);
            this.pbTrafficLight.Name = "pbTrafficLight";
            this.pbTrafficLight.Size = new System.Drawing.Size(142, 248);
            this.pbTrafficLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrafficLight.TabIndex = 0;
            this.pbTrafficLight.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTimer.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(0, 248);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(142, 55);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "??";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ctrlTrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbTrafficLight);
            this.Controls.Add(this.lblTimer);
            this.Name = "ctrlTrafficLight";
            this.Size = new System.Drawing.Size(142, 303);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficLight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTrafficLight;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
    }
}
