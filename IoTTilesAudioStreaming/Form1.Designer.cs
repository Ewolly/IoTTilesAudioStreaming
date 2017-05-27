namespace IoTTilesAudioStreaming
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
            this.SendCb = new System.Windows.Forms.CheckBox();
            this.RecieveCb = new System.Windows.Forms.CheckBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendCb
            // 
            this.SendCb.Appearance = System.Windows.Forms.Appearance.Button;
            this.SendCb.AutoSize = true;
            this.SendCb.Location = new System.Drawing.Point(204, 65);
            this.SendCb.Name = "SendCb";
            this.SendCb.Size = new System.Drawing.Size(42, 23);
            this.SendCb.TabIndex = 0;
            this.SendCb.Text = "Send";
            this.SendCb.UseVisualStyleBackColor = true;
            this.SendCb.CheckedChanged += new System.EventHandler(this.SendCb_CheckedChanged);
            // 
            // RecieveCb
            // 
            this.RecieveCb.Appearance = System.Windows.Forms.Appearance.Button;
            this.RecieveCb.AutoSize = true;
            this.RecieveCb.Location = new System.Drawing.Point(204, 101);
            this.RecieveCb.Name = "RecieveCb";
            this.RecieveCb.Size = new System.Drawing.Size(57, 23);
            this.RecieveCb.TabIndex = 0;
            this.RecieveCb.Text = "Recieve";
            this.RecieveCb.UseVisualStyleBackColor = true;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(186, 161);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectBtn.TabIndex = 1;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 190);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(451, 141);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 336);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.RecieveCb);
            this.Controls.Add(this.SendCb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox SendCb;
        private System.Windows.Forms.CheckBox RecieveCb;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

