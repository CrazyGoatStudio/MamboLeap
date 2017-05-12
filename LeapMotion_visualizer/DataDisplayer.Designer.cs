namespace LeapMotion_visualizer
{
    partial class DataDisplayer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRightHand_roll = new System.Windows.Forms.Label();
            this.lblRightHand_pitch = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRightHand_yaw = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLeftHand_roll = new System.Windows.Forms.Label();
            this.lblLeftHand_pitch = new System.Windows.Forms.Label();
            this.lblLeftHand_yaw = new System.Windows.Forms.Label();
            this.btStartSocket = new System.Windows.Forms.Button();
            this.btStopSocket = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Right Hand Rotation: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Left Hand Rotation: ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.lblRightHand_roll, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRightHand_pitch, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRightHand_yaw, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(449, 70);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblRightHand_roll
            // 
            this.lblRightHand_roll.AutoSize = true;
            this.lblRightHand_roll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRightHand_roll.Location = new System.Drawing.Point(303, 20);
            this.lblRightHand_roll.Name = "lblRightHand_roll";
            this.lblRightHand_roll.Size = new System.Drawing.Size(143, 50);
            this.lblRightHand_roll.TabIndex = 5;
            this.lblRightHand_roll.Text = "0";
            this.lblRightHand_roll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRightHand_pitch
            // 
            this.lblRightHand_pitch.AutoSize = true;
            this.lblRightHand_pitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRightHand_pitch.Location = new System.Drawing.Point(151, 20);
            this.lblRightHand_pitch.Name = "lblRightHand_pitch";
            this.lblRightHand_pitch.Size = new System.Drawing.Size(146, 50);
            this.lblRightHand_pitch.TabIndex = 4;
            this.lblRightHand_pitch.Text = "0";
            this.lblRightHand_pitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(303, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Roll";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(151, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Pitch";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yaw";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRightHand_yaw
            // 
            this.lblRightHand_yaw.AutoSize = true;
            this.lblRightHand_yaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRightHand_yaw.Location = new System.Drawing.Point(3, 20);
            this.lblRightHand_yaw.Name = "lblRightHand_yaw";
            this.lblRightHand_yaw.Size = new System.Drawing.Size(142, 50);
            this.lblRightHand_yaw.TabIndex = 3;
            this.lblRightHand_yaw.Text = "0";
            this.lblRightHand_yaw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.Controls.Add(this.lblLeftHand_yaw, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblLeftHand_pitch, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblLeftHand_roll, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 129);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(449, 70);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(303, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Roll";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(151, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Pitch";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Yaw";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeftHand_roll
            // 
            this.lblLeftHand_roll.AutoSize = true;
            this.lblLeftHand_roll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLeftHand_roll.Location = new System.Drawing.Point(303, 20);
            this.lblLeftHand_roll.Name = "lblLeftHand_roll";
            this.lblLeftHand_roll.Size = new System.Drawing.Size(143, 50);
            this.lblLeftHand_roll.TabIndex = 4;
            this.lblLeftHand_roll.Text = "0";
            this.lblLeftHand_roll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLeftHand_pitch
            // 
            this.lblLeftHand_pitch.AutoSize = true;
            this.lblLeftHand_pitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLeftHand_pitch.Location = new System.Drawing.Point(151, 20);
            this.lblLeftHand_pitch.Name = "lblLeftHand_pitch";
            this.lblLeftHand_pitch.Size = new System.Drawing.Size(146, 50);
            this.lblLeftHand_pitch.TabIndex = 5;
            this.lblLeftHand_pitch.Text = "0";
            this.lblLeftHand_pitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLeftHand_yaw
            // 
            this.lblLeftHand_yaw.AutoSize = true;
            this.lblLeftHand_yaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLeftHand_yaw.Location = new System.Drawing.Point(3, 20);
            this.lblLeftHand_yaw.Name = "lblLeftHand_yaw";
            this.lblLeftHand_yaw.Size = new System.Drawing.Size(142, 50);
            this.lblLeftHand_yaw.TabIndex = 6;
            this.lblLeftHand_yaw.Text = "0";
            this.lblLeftHand_yaw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btStartSocket
            // 
            this.btStartSocket.Location = new System.Drawing.Point(16, 234);
            this.btStartSocket.Name = "btStartSocket";
            this.btStartSocket.Size = new System.Drawing.Size(145, 60);
            this.btStartSocket.TabIndex = 4;
            this.btStartSocket.Text = "Start Socket";
            this.btStartSocket.UseVisualStyleBackColor = true;
            this.btStartSocket.Click += new System.EventHandler(this.btStartSocket_Click);
            // 
            // btStopSocket
            // 
            this.btStopSocket.Location = new System.Drawing.Point(317, 234);
            this.btStopSocket.Name = "btStopSocket";
            this.btStopSocket.Size = new System.Drawing.Size(145, 60);
            this.btStopSocket.TabIndex = 5;
            this.btStopSocket.Text = "Stop Socket";
            this.btStopSocket.UseVisualStyleBackColor = true;
            this.btStopSocket.Click += new System.EventHandler(this.btStopSocket_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(15, 319);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(447, 136);
            this.txtStatus.TabIndex = 7;
            // 
            // DataDisplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 467);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btStopSocket);
            this.Controls.Add(this.btStartSocket);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DataDisplayer";
            this.Text = "DataDisplayer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRightHand_roll;
        private System.Windows.Forms.Label lblRightHand_pitch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRightHand_yaw;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLeftHand_yaw;
        private System.Windows.Forms.Label lblLeftHand_pitch;
        private System.Windows.Forms.Label lblLeftHand_roll;
        private System.Windows.Forms.Button btStartSocket;
        private System.Windows.Forms.Button btStopSocket;
        private System.Windows.Forms.TextBox txtStatus;
    }
}