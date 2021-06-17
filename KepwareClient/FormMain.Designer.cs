
namespace KepwareClient
{
    partial class FormMain
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
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelOPC1 = new System.Windows.Forms.Label();
            this.labelRamp = new System.Windows.Forms.Label();
            this.labelRandom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRamp = new System.Windows.Forms.TextBox();
            this.textBoxRandom = new System.Windows.Forms.TextBox();
            this.textBoxSine = new System.Windows.Forms.TextBox();
            this.buttonSQL = new System.Windows.Forms.Button();
            this.labelSQLWriteStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(302, 399);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "Настройки";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(20, 399);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(104, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Подключиться";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelOPC1
            // 
            this.labelOPC1.AutoSize = true;
            this.labelOPC1.Location = new System.Drawing.Point(30, 13);
            this.labelOPC1.Name = "labelOPC1";
            this.labelOPC1.Size = new System.Drawing.Size(37, 15);
            this.labelOPC1.TabIndex = 2;
            this.labelOPC1.Text = "OPC I";
            // 
            // labelRamp
            // 
            this.labelRamp.AutoSize = true;
            this.labelRamp.Location = new System.Drawing.Point(27, 49);
            this.labelRamp.Name = "labelRamp";
            this.labelRamp.Size = new System.Drawing.Size(38, 15);
            this.labelRamp.TabIndex = 3;
            this.labelRamp.Text = "Ramp";
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.Location = new System.Drawing.Point(27, 78);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(52, 15);
            this.labelRandom.TabIndex = 4;
            this.labelRandom.Text = "Random";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sine";
            // 
            // textBoxRamp
            // 
            this.textBoxRamp.Location = new System.Drawing.Point(85, 46);
            this.textBoxRamp.Name = "textBoxRamp";
            this.textBoxRamp.Size = new System.Drawing.Size(100, 23);
            this.textBoxRamp.TabIndex = 6;
            // 
            // textBoxRandom
            // 
            this.textBoxRandom.Location = new System.Drawing.Point(85, 75);
            this.textBoxRandom.Name = "textBoxRandom";
            this.textBoxRandom.Size = new System.Drawing.Size(100, 23);
            this.textBoxRandom.TabIndex = 7;
            // 
            // textBoxSine
            // 
            this.textBoxSine.Location = new System.Drawing.Point(85, 105);
            this.textBoxSine.Name = "textBoxSine";
            this.textBoxSine.Size = new System.Drawing.Size(100, 23);
            this.textBoxSine.TabIndex = 8;
            // 
            // buttonSQL
            // 
            this.buttonSQL.Location = new System.Drawing.Point(151, 399);
            this.buttonSQL.Name = "buttonSQL";
            this.buttonSQL.Size = new System.Drawing.Size(95, 23);
            this.buttonSQL.TabIndex = 9;
            this.buttonSQL.Text = "Запись в БД";
            this.buttonSQL.UseVisualStyleBackColor = true;
            this.buttonSQL.Click += new System.EventHandler(this.buttonSQL_Click);
            // 
            // labelSQLWriteStatus
            // 
            this.labelSQLWriteStatus.AutoSize = true;
            this.labelSQLWriteStatus.Location = new System.Drawing.Point(13, 428);
            this.labelSQLWriteStatus.Name = "labelSQLWriteStatus";
            this.labelSQLWriteStatus.Size = new System.Drawing.Size(111, 15);
            this.labelSQLWriteStatus.TabIndex = 10;
            this.labelSQLWriteStatus.Text = "Статус записи в БД";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 455);
            this.Controls.Add(this.labelSQLWriteStatus);
            this.Controls.Add(this.buttonSQL);
            this.Controls.Add(this.textBoxSine);
            this.Controls.Add(this.textBoxRandom);
            this.Controls.Add(this.textBoxRamp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRandom);
            this.Controls.Add(this.labelRamp);
            this.Controls.Add(this.labelOPC1);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonSettings);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelOPC1;
        private System.Windows.Forms.Label labelRamp;
        private System.Windows.Forms.Label labelRandom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRamp;
        private System.Windows.Forms.TextBox textBoxRandom;
        private System.Windows.Forms.TextBox textBoxSine;
        private System.Windows.Forms.Button buttonSQL;
        private System.Windows.Forms.Label labelSQLWriteStatus;
    }
}

