namespace LeapMotion_visualizer
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.displayID = new System.Windows.Forms.Label();
            this.displayTimestamp = new System.Windows.Forms.Label();
            this.displayFPS = new System.Windows.Forms.Label();
            this.displayHandCount = new System.Windows.Forms.Label();
            this.displayImages = new System.Windows.Forms.PictureBox();
            this.lblrightHandTittle = new System.Windows.Forms.Label();
            this.lblLeftHandTittle = new System.Windows.Forms.Label();
            this.lblRightHandC_X = new System.Windows.Forms.Label();
            this.lblLeftHandC_X = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRightHandC_Y = new System.Windows.Forms.Label();
            this.lblLeftHandC_Y = new System.Windows.Forms.Label();
            this.lblLeftHandC_Z = new System.Windows.Forms.Label();
            this.lblRightHandC_Z = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_startService = new System.Windows.Forms.Button();
            this.bt_stopService = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayImages)).BeginInit();
            this.SuspendLayout();
            // 
            // displayID
            // 
            this.displayID.AutoSize = true;
            this.displayID.Location = new System.Drawing.Point(12, 9);
            this.displayID.Name = "displayID";
            this.displayID.Size = new System.Drawing.Size(35, 13);
            this.displayID.TabIndex = 0;
            this.displayID.Text = "label1";
            // 
            // displayTimestamp
            // 
            this.displayTimestamp.AutoSize = true;
            this.displayTimestamp.Location = new System.Drawing.Point(111, 9);
            this.displayTimestamp.Name = "displayTimestamp";
            this.displayTimestamp.Size = new System.Drawing.Size(35, 13);
            this.displayTimestamp.TabIndex = 1;
            this.displayTimestamp.Text = "label2";
            // 
            // displayFPS
            // 
            this.displayFPS.AutoSize = true;
            this.displayFPS.Location = new System.Drawing.Point(222, 9);
            this.displayFPS.Name = "displayFPS";
            this.displayFPS.Size = new System.Drawing.Size(35, 13);
            this.displayFPS.TabIndex = 2;
            this.displayFPS.Text = "label3";
            // 
            // displayHandCount
            // 
            this.displayHandCount.AutoSize = true;
            this.displayHandCount.Location = new System.Drawing.Point(310, 9);
            this.displayHandCount.Name = "displayHandCount";
            this.displayHandCount.Size = new System.Drawing.Size(35, 13);
            this.displayHandCount.TabIndex = 3;
            this.displayHandCount.Text = "label4";
            // 
            // displayImages
            // 
            this.displayImages.Location = new System.Drawing.Point(15, 25);
            this.displayImages.Name = "displayImages";
            this.displayImages.Size = new System.Drawing.Size(640, 480);
            this.displayImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.displayImages.TabIndex = 4;
            this.displayImages.TabStop = false;
            // 
            // lblrightHandTittle
            // 
            this.lblrightHandTittle.AutoSize = true;
            this.lblrightHandTittle.Location = new System.Drawing.Point(12, 538);
            this.lblrightHandTittle.Name = "lblrightHandTittle";
            this.lblrightHandTittle.Size = new System.Drawing.Size(64, 13);
            this.lblrightHandTittle.TabIndex = 5;
            this.lblrightHandTittle.Text = "Right Hand:";
            // 
            // lblLeftHandTittle
            // 
            this.lblLeftHandTittle.AutoSize = true;
            this.lblLeftHandTittle.Location = new System.Drawing.Point(12, 583);
            this.lblLeftHandTittle.Name = "lblLeftHandTittle";
            this.lblLeftHandTittle.Size = new System.Drawing.Size(57, 13);
            this.lblLeftHandTittle.TabIndex = 6;
            this.lblLeftHandTittle.Text = "Left Hand:";
            // 
            // lblRightHandC_X
            // 
            this.lblRightHandC_X.AutoSize = true;
            this.lblRightHandC_X.Location = new System.Drawing.Point(82, 538);
            this.lblRightHandC_X.Name = "lblRightHandC_X";
            this.lblRightHandC_X.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRightHandC_X.Size = new System.Drawing.Size(13, 13);
            this.lblRightHandC_X.TabIndex = 7;
            this.lblRightHandC_X.Text = "0";
            // 
            // lblLeftHandC_X
            // 
            this.lblLeftHandC_X.AutoSize = true;
            this.lblLeftHandC_X.Location = new System.Drawing.Point(82, 583);
            this.lblLeftHandC_X.Name = "lblLeftHandC_X";
            this.lblLeftHandC_X.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLeftHandC_X.Size = new System.Drawing.Size(13, 13);
            this.lblLeftHandC_X.TabIndex = 8;
            this.lblLeftHandC_X.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Z";
            // 
            // lblRightHandC_Y
            // 
            this.lblRightHandC_Y.AutoSize = true;
            this.lblRightHandC_Y.Location = new System.Drawing.Point(187, 538);
            this.lblRightHandC_Y.Name = "lblRightHandC_Y";
            this.lblRightHandC_Y.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRightHandC_Y.Size = new System.Drawing.Size(13, 13);
            this.lblRightHandC_Y.TabIndex = 12;
            this.lblRightHandC_Y.Text = "0";
            // 
            // lblLeftHandC_Y
            // 
            this.lblLeftHandC_Y.AutoSize = true;
            this.lblLeftHandC_Y.Location = new System.Drawing.Point(187, 583);
            this.lblLeftHandC_Y.Name = "lblLeftHandC_Y";
            this.lblLeftHandC_Y.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLeftHandC_Y.Size = new System.Drawing.Size(13, 13);
            this.lblLeftHandC_Y.TabIndex = 13;
            this.lblLeftHandC_Y.Text = "0";
            // 
            // lblLeftHandC_Z
            // 
            this.lblLeftHandC_Z.AutoSize = true;
            this.lblLeftHandC_Z.Location = new System.Drawing.Point(293, 583);
            this.lblLeftHandC_Z.Name = "lblLeftHandC_Z";
            this.lblLeftHandC_Z.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLeftHandC_Z.Size = new System.Drawing.Size(13, 13);
            this.lblLeftHandC_Z.TabIndex = 15;
            this.lblLeftHandC_Z.Text = "0";
            // 
            // lblRightHandC_Z
            // 
            this.lblRightHandC_Z.AutoSize = true;
            this.lblRightHandC_Z.Location = new System.Drawing.Point(293, 538);
            this.lblRightHandC_Z.Name = "lblRightHandC_Z";
            this.lblRightHandC_Z.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRightHandC_Z.Size = new System.Drawing.Size(13, 13);
            this.lblRightHandC_Z.TabIndex = 14;
            this.lblRightHandC_Z.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Start Leap Motion Service";
            // 
            // bt_startService
            // 
            this.bt_startService.Location = new System.Drawing.Point(418, 527);
            this.bt_startService.Name = "bt_startService";
            this.bt_startService.Size = new System.Drawing.Size(127, 23);
            this.bt_startService.TabIndex = 17;
            this.bt_startService.Text = "Start Service";
            this.bt_startService.UseVisualStyleBackColor = true;
            this.bt_startService.Click += new System.EventHandler(this.bt_startService_Click);
            // 
            // bt_stopService
            // 
            this.bt_stopService.Location = new System.Drawing.Point(418, 578);
            this.bt_stopService.Name = "bt_stopService";
            this.bt_stopService.Size = new System.Drawing.Size(127, 23);
            this.bt_stopService.TabIndex = 19;
            this.bt_stopService.Text = "Stop Service";
            this.bt_stopService.UseVisualStyleBackColor = true;
            this.bt_stopService.Click += new System.EventHandler(this.bt_stopService_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 559);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Stop Leap Motion Service";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 611);
            this.Controls.Add(this.bt_stopService);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_startService);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLeftHandC_Z);
            this.Controls.Add(this.lblRightHandC_Z);
            this.Controls.Add(this.lblLeftHandC_Y);
            this.Controls.Add(this.lblRightHandC_Y);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLeftHandC_X);
            this.Controls.Add(this.lblRightHandC_X);
            this.Controls.Add(this.lblLeftHandTittle);
            this.Controls.Add(this.lblrightHandTittle);
            this.Controls.Add(this.displayImages);
            this.Controls.Add(this.displayHandCount);
            this.Controls.Add(this.displayFPS);
            this.Controls.Add(this.displayTimestamp);
            this.Controls.Add(this.displayID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Frame Data";
            ((System.ComponentModel.ISupportInitialize)(this.displayImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayID;
        private System.Windows.Forms.Label displayTimestamp;
        private System.Windows.Forms.Label displayFPS;
        private System.Windows.Forms.Label displayHandCount;
        private System.Windows.Forms.PictureBox displayImages;
        private System.Windows.Forms.Label lblrightHandTittle;
        private System.Windows.Forms.Label lblLeftHandTittle;
        private System.Windows.Forms.Label lblRightHandC_X;
        private System.Windows.Forms.Label lblLeftHandC_X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRightHandC_Y;
        private System.Windows.Forms.Label lblLeftHandC_Y;
        private System.Windows.Forms.Label lblLeftHandC_Z;
        private System.Windows.Forms.Label lblRightHandC_Z;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_startService;
        private System.Windows.Forms.Button bt_stopService;
        private System.Windows.Forms.Label label5;
    }
}

