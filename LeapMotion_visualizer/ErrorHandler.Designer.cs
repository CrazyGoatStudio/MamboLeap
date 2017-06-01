namespace LeapMotion_visualizer
{
    partial class ErrorHandler
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
            this.txtErrorHandlerMsg = new System.Windows.Forms.TextBox();
            this.lblErrorHandlerTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtErrorHandlerMsg
            // 
            this.txtErrorHandlerMsg.Location = new System.Drawing.Point(12, 40);
            this.txtErrorHandlerMsg.Multiline = true;
            this.txtErrorHandlerMsg.Name = "txtErrorHandlerMsg";
            this.txtErrorHandlerMsg.Size = new System.Drawing.Size(582, 77);
            this.txtErrorHandlerMsg.TabIndex = 0;
            // 
            // lblErrorHandlerTitle
            // 
            this.lblErrorHandlerTitle.AutoSize = true;
            this.lblErrorHandlerTitle.Location = new System.Drawing.Point(13, 13);
            this.lblErrorHandlerTitle.Name = "lblErrorHandlerTitle";
            this.lblErrorHandlerTitle.Size = new System.Drawing.Size(68, 13);
            this.lblErrorHandlerTitle.TabIndex = 1;
            this.lblErrorHandlerTitle.Text = "Nombre error";
            // 
            // ErrorHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 129);
            this.Controls.Add(this.lblErrorHandlerTitle);
            this.Controls.Add(this.txtErrorHandlerMsg);
            this.Name = "ErrorHandler";
            this.Text = "ErrorHandler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtErrorHandlerMsg;
        private System.Windows.Forms.Label lblErrorHandlerTitle;
    }
}