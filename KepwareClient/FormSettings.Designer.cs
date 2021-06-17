
namespace KepwareClient
{
    partial class FormSettings
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxOPCAddress = new System.Windows.Forms.TextBox();
            this.textBoxOPCTimeOut = new System.Windows.Forms.TextBox();
            this.labelOPCURL = new System.Windows.Forms.Label();
            this.labelOPCTimeOut = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(168, 211);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Принять";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(277, 211);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(65, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxOPCAddress
            // 
            this.textBoxOPCAddress.Location = new System.Drawing.Point(13, 27);
            this.textBoxOPCAddress.Name = "textBoxOPCAddress";
            this.textBoxOPCAddress.Size = new System.Drawing.Size(100, 23);
            this.textBoxOPCAddress.TabIndex = 2;
            // 
            // textBoxOPCTimeOut
            // 
            this.textBoxOPCTimeOut.Location = new System.Drawing.Point(13, 87);
            this.textBoxOPCTimeOut.Name = "textBoxOPCTimeOut";
            this.textBoxOPCTimeOut.Size = new System.Drawing.Size(100, 23);
            this.textBoxOPCTimeOut.TabIndex = 3;
            // 
            // labelOPCURL
            // 
            this.labelOPCURL.AutoSize = true;
            this.labelOPCURL.Location = new System.Drawing.Point(13, 9);
            this.labelOPCURL.Name = "labelOPCURL";
            this.labelOPCURL.Size = new System.Drawing.Size(99, 15);
            this.labelOPCURL.TabIndex = 4;
            this.labelOPCURL.Text = "OPCServer Адрес";
            // 
            // labelOPCTimeOut
            // 
            this.labelOPCTimeOut.AutoSize = true;
            this.labelOPCTimeOut.Location = new System.Drawing.Point(13, 69);
            this.labelOPCTimeOut.Name = "labelOPCTimeOut";
            this.labelOPCTimeOut.Size = new System.Drawing.Size(100, 15);
            this.labelOPCTimeOut.TabIndex = 5;
            this.labelOPCTimeOut.Text = "Время ожидания";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(138, 27);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 23);
            this.textBoxPort.TabIndex = 6;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(138, 8);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(35, 15);
            this.labelPort.TabIndex = 7;
            this.labelPort.Text = "Порт";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 263);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelOPCTimeOut);
            this.Controls.Add(this.labelOPCURL);
            this.Controls.Add(this.textBoxOPCTimeOut);
            this.Controls.Add(this.textBoxOPCAddress);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Name = "FormSettings";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxOPCAddress;
        private System.Windows.Forms.TextBox textBoxOPCTimeOut;
        private System.Windows.Forms.Label labelOPCURL;
        private System.Windows.Forms.Label labelOPCTimeOut;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelPort;
    }
}