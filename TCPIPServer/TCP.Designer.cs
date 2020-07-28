namespace TCPIPServer
{
    partial class TCP
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textIPnum = new System.Windows.Forms.TextBox();
            this.textportnum = new System.Windows.Forms.TextBox();
            this.textmessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonenter = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // textIPnum
            // 
            this.textIPnum.Location = new System.Drawing.Point(49, 11);
            this.textIPnum.Margin = new System.Windows.Forms.Padding(4);
            this.textIPnum.Name = "textIPnum";
            this.textIPnum.Size = new System.Drawing.Size(108, 25);
            this.textIPnum.TabIndex = 0;
            // 
            // textportnum
            // 
            this.textportnum.Location = new System.Drawing.Point(226, 11);
            this.textportnum.Margin = new System.Windows.Forms.Padding(4);
            this.textportnum.Name = "textportnum";
            this.textportnum.Size = new System.Drawing.Size(108, 25);
            this.textportnum.TabIndex = 0;
            // 
            // textmessage
            // 
            this.textmessage.Location = new System.Drawing.Point(13, 44);
            this.textmessage.Margin = new System.Windows.Forms.Padding(4);
            this.textmessage.Multiline = true;
            this.textmessage.Name = "textmessage";
            this.textmessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textmessage.Size = new System.Drawing.Size(428, 165);
            this.textmessage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(172, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // buttonenter
            // 
            this.buttonenter.Location = new System.Drawing.Point(349, 11);
            this.buttonenter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonenter.Name = "buttonenter";
            this.buttonenter.Size = new System.Drawing.Size(92, 25);
            this.buttonenter.TabIndex = 2;
            this.buttonenter.Text = "Set";
            this.buttonenter.UseVisualStyleBackColor = true;
            this.buttonenter.Click += new System.EventHandler(this.buttonenter_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // TCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 328);
            this.Controls.Add(this.buttonenter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textmessage);
            this.Controls.Add(this.textportnum);
            this.Controls.Add(this.textIPnum);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TCP";
            this.Text = "TCP";
            this.Load += new System.EventHandler(this.TCP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textIPnum;
        private System.Windows.Forms.TextBox textportnum;
        private System.Windows.Forms.TextBox textmessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonenter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

