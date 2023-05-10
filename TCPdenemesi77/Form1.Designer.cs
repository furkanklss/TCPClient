namespace TCPdenemesi77
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txPORT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCON = new System.Windows.Forms.Button();
            this.txtSEND = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSEND = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(91, 23);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(300, 20);
            this.txtIP.TabIndex = 1;
            // 
            // txPORT
            // 
            this.txPORT.Location = new System.Drawing.Point(91, 59);
            this.txPORT.Name = "txPORT";
            this.txPORT.Size = new System.Drawing.Size(300, 20);
            this.txPORT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // btnCON
            // 
            this.btnCON.Location = new System.Drawing.Point(15, 100);
            this.btnCON.Name = "btnCON";
            this.btnCON.Size = new System.Drawing.Size(376, 23);
            this.btnCON.TabIndex = 4;
            this.btnCON.Text = "CONNECT";
            this.btnCON.UseVisualStyleBackColor = true;
            this.btnCON.Click += new System.EventHandler(this.btnCON_Click_1);
            // 
            // txtSEND
            // 
            this.txtSEND.Location = new System.Drawing.Point(16, 187);
            this.txtSEND.Multiline = true;
            this.txtSEND.Name = "txtSEND";
            this.txtSEND.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSEND.Size = new System.Drawing.Size(375, 136);
            this.txtSEND.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SENDER";
            // 
            // txtIN
            // 
            this.txtIN.Location = new System.Drawing.Point(16, 418);
            this.txtIN.Multiline = true;
            this.txtIN.Name = "txtIN";
            this.txtIN.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtIN.Size = new System.Drawing.Size(375, 136);
            this.txtIN.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Receive";
            // 
            // btnSEND
            // 
            this.btnSEND.Location = new System.Drawing.Point(316, 340);
            this.btnSEND.Name = "btnSEND";
            this.btnSEND.Size = new System.Drawing.Size(75, 23);
            this.btnSEND.TabIndex = 9;
            this.btnSEND.Text = "SEND";
            this.btnSEND.UseVisualStyleBackColor = true;
            this.btnSEND.Click += new System.EventHandler(this.btnSEND_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 582);
            this.Controls.Add(this.btnSEND);
            this.Controls.Add(this.txtIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSEND);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCON);
            this.Controls.Add(this.txPORT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txPORT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCON;
        private System.Windows.Forms.TextBox txtSEND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSEND;
    }
}

