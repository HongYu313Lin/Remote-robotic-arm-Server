namespace XYZrobot
{
    partial class XYZrobot
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_release = new System.Windows.Forms.Button();
            this.btn_Power = new System.Windows.Forms.Button();
            this.btn_L1 = new System.Windows.Forms.Button();
            this.btn_L2 = new System.Windows.Forms.Button();
            this.btn_L3 = new System.Windows.Forms.Button();
            this.btn_R3 = new System.Windows.Forms.Button();
            this.btn_R2 = new System.Windows.Forms.Button();
            this.btn_R1 = new System.Windows.Forms.Button();
            this.btn_LD = new System.Windows.Forms.Button();
            this.btn_LR = new System.Windows.Forms.Button();
            this.btn_LU = new System.Windows.Forms.Button();
            this.btn_LL = new System.Windows.Forms.Button();
            this.btn_RL = new System.Windows.Forms.Button();
            this.btn_RD = new System.Windows.Forms.Button();
            this.btn_RR = new System.Windows.Forms.Button();
            this.btn_RU = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_release
            // 
            this.btn_release.Location = new System.Drawing.Point(381, 320);
            this.btn_release.Name = "btn_release";
            this.btn_release.Size = new System.Drawing.Size(93, 43);
            this.btn_release.TabIndex = 0;
            this.btn_release.Text = "Release";
            this.btn_release.UseVisualStyleBackColor = true;
            this.btn_release.Click += new System.EventHandler(this.btn_release_Click);
            // 
            // btn_Power
            // 
            this.btn_Power.Location = new System.Drawing.Point(381, 195);
            this.btn_Power.Name = "btn_Power";
            this.btn_Power.Size = new System.Drawing.Size(93, 43);
            this.btn_Power.TabIndex = 1;
            this.btn_Power.Text = "Power";
            this.btn_Power.UseVisualStyleBackColor = true;
            this.btn_Power.Click += new System.EventHandler(this.btn_Power_Click);
            // 
            // btn_L1
            // 
            this.btn_L1.Location = new System.Drawing.Point(230, 26);
            this.btn_L1.Name = "btn_L1";
            this.btn_L1.Size = new System.Drawing.Size(93, 43);
            this.btn_L1.TabIndex = 2;
            this.btn_L1.Text = "L1";
            this.btn_L1.UseVisualStyleBackColor = true;
            this.btn_L1.Click += new System.EventHandler(this.btn_L1_Click);
            // 
            // btn_L2
            // 
            this.btn_L2.Location = new System.Drawing.Point(230, 75);
            this.btn_L2.Name = "btn_L2";
            this.btn_L2.Size = new System.Drawing.Size(93, 43);
            this.btn_L2.TabIndex = 3;
            this.btn_L2.Text = "L2";
            this.btn_L2.UseVisualStyleBackColor = true;
            this.btn_L2.Click += new System.EventHandler(this.btn_L2_Click);
            // 
            // btn_L3
            // 
            this.btn_L3.Location = new System.Drawing.Point(230, 401);
            this.btn_L3.Name = "btn_L3";
            this.btn_L3.Size = new System.Drawing.Size(93, 43);
            this.btn_L3.TabIndex = 4;
            this.btn_L3.Text = "L3";
            this.btn_L3.UseVisualStyleBackColor = true;
            this.btn_L3.Click += new System.EventHandler(this.btn_L3_Click);
            // 
            // btn_R3
            // 
            this.btn_R3.Location = new System.Drawing.Point(515, 401);
            this.btn_R3.Name = "btn_R3";
            this.btn_R3.Size = new System.Drawing.Size(93, 43);
            this.btn_R3.TabIndex = 7;
            this.btn_R3.Text = "R3";
            this.btn_R3.UseVisualStyleBackColor = true;
            this.btn_R3.Click += new System.EventHandler(this.btn_R3_Click);
            // 
            // btn_R2
            // 
            this.btn_R2.Location = new System.Drawing.Point(515, 75);
            this.btn_R2.Name = "btn_R2";
            this.btn_R2.Size = new System.Drawing.Size(93, 43);
            this.btn_R2.TabIndex = 6;
            this.btn_R2.Text = "R2";
            this.btn_R2.UseVisualStyleBackColor = true;
            this.btn_R2.Click += new System.EventHandler(this.btn_R2_Click);
            // 
            // btn_R1
            // 
            this.btn_R1.Location = new System.Drawing.Point(515, 26);
            this.btn_R1.Name = "btn_R1";
            this.btn_R1.Size = new System.Drawing.Size(93, 43);
            this.btn_R1.TabIndex = 5;
            this.btn_R1.Text = "R1";
            this.btn_R1.UseVisualStyleBackColor = true;
            this.btn_R1.Click += new System.EventHandler(this.btn_R1_Click);
            // 
            // btn_LD
            // 
            this.btn_LD.Location = new System.Drawing.Point(128, 320);
            this.btn_LD.Name = "btn_LD";
            this.btn_LD.Size = new System.Drawing.Size(93, 43);
            this.btn_LD.TabIndex = 10;
            this.btn_LD.Text = "Down";
            this.btn_LD.UseVisualStyleBackColor = true;
            this.btn_LD.Click += new System.EventHandler(this.btn_LD_Click);
            // 
            // btn_LR
            // 
            this.btn_LR.Location = new System.Drawing.Point(230, 258);
            this.btn_LR.Name = "btn_LR";
            this.btn_LR.Size = new System.Drawing.Size(93, 43);
            this.btn_LR.TabIndex = 9;
            this.btn_LR.Text = "Right";
            this.btn_LR.UseVisualStyleBackColor = true;
            this.btn_LR.Click += new System.EventHandler(this.btn_LR_Click);
            // 
            // btn_LU
            // 
            this.btn_LU.Location = new System.Drawing.Point(128, 195);
            this.btn_LU.Name = "btn_LU";
            this.btn_LU.Size = new System.Drawing.Size(93, 43);
            this.btn_LU.TabIndex = 8;
            this.btn_LU.Text = "Up";
            this.btn_LU.UseVisualStyleBackColor = true;
            this.btn_LU.Click += new System.EventHandler(this.btn_LU_Click);
            // 
            // btn_LL
            // 
            this.btn_LL.Location = new System.Drawing.Point(29, 258);
            this.btn_LL.Name = "btn_LL";
            this.btn_LL.Size = new System.Drawing.Size(93, 43);
            this.btn_LL.TabIndex = 11;
            this.btn_LL.Text = "Left";
            this.btn_LL.UseVisualStyleBackColor = true;
            this.btn_LL.Click += new System.EventHandler(this.btn_LL_Click);
            // 
            // btn_RL
            // 
            this.btn_RL.Location = new System.Drawing.Point(513, 258);
            this.btn_RL.Name = "btn_RL";
            this.btn_RL.Size = new System.Drawing.Size(93, 43);
            this.btn_RL.TabIndex = 15;
            this.btn_RL.Text = "Left";
            this.btn_RL.UseVisualStyleBackColor = true;
            this.btn_RL.Click += new System.EventHandler(this.btn_RL_Click);
            // 
            // btn_RD
            // 
            this.btn_RD.Location = new System.Drawing.Point(612, 320);
            this.btn_RD.Name = "btn_RD";
            this.btn_RD.Size = new System.Drawing.Size(93, 43);
            this.btn_RD.TabIndex = 14;
            this.btn_RD.Text = "Down";
            this.btn_RD.UseVisualStyleBackColor = true;
            this.btn_RD.Click += new System.EventHandler(this.btn_RD_Click);
            // 
            // btn_RR
            // 
            this.btn_RR.Location = new System.Drawing.Point(714, 258);
            this.btn_RR.Name = "btn_RR";
            this.btn_RR.Size = new System.Drawing.Size(93, 43);
            this.btn_RR.TabIndex = 13;
            this.btn_RR.Text = "Right";
            this.btn_RR.UseVisualStyleBackColor = true;
            this.btn_RR.Click += new System.EventHandler(this.btn_RR_Click);
            // 
            // btn_RU
            // 
            this.btn_RU.Location = new System.Drawing.Point(612, 195);
            this.btn_RU.Name = "btn_RU";
            this.btn_RU.Size = new System.Drawing.Size(93, 43);
            this.btn_RU.TabIndex = 12;
            this.btn_RU.Text = "Up";
            this.btn_RU.UseVisualStyleBackColor = true;
            this.btn_RU.Click += new System.EventHandler(this.btn_RU_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "9600";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "COM18";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // XYZrobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_RL);
            this.Controls.Add(this.btn_RD);
            this.Controls.Add(this.btn_RR);
            this.Controls.Add(this.btn_RU);
            this.Controls.Add(this.btn_LL);
            this.Controls.Add(this.btn_LD);
            this.Controls.Add(this.btn_LR);
            this.Controls.Add(this.btn_LU);
            this.Controls.Add(this.btn_R3);
            this.Controls.Add(this.btn_R2);
            this.Controls.Add(this.btn_R1);
            this.Controls.Add(this.btn_L3);
            this.Controls.Add(this.btn_L2);
            this.Controls.Add(this.btn_L1);
            this.Controls.Add(this.btn_Power);
            this.Controls.Add(this.btn_release);
            this.Name = "XYZrobot";
            this.Text = "XYZrobot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_release;
        private System.Windows.Forms.Button btn_Power;
        private System.Windows.Forms.Button btn_L1;
        private System.Windows.Forms.Button btn_L2;
        private System.Windows.Forms.Button btn_L3;
        private System.Windows.Forms.Button btn_R3;
        private System.Windows.Forms.Button btn_R2;
        private System.Windows.Forms.Button btn_R1;
        private System.Windows.Forms.Button btn_LD;
        private System.Windows.Forms.Button btn_LR;
        private System.Windows.Forms.Button btn_LU;
        private System.Windows.Forms.Button btn_LL;
        private System.Windows.Forms.Button btn_RL;
        private System.Windows.Forms.Button btn_RD;
        private System.Windows.Forms.Button btn_RR;
        private System.Windows.Forms.Button btn_RU;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

