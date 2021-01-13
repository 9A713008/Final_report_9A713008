namespace Final_report_9A713008
{
    partial class FM1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lab1 = new System.Windows.Forms.Label();
            this.pB1 = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab1.Location = new System.Drawing.Point(259, 13);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(156, 37);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "亂數Poker";
            // 
            // pB1
            // 
            this.pB1.Location = new System.Drawing.Point(221, 64);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(238, 273);
            this.pB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB1.TabIndex = 1;
            this.pB1.TabStop = false;
            this.pB1.Click += new System.EventHandler(this.pB1_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1.Location = new System.Drawing.Point(310, 349);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(73, 78);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "按";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // FM1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.pB1);
            this.Controls.Add(this.lab1);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "FM1";
            this.Text = "這叫做視窗";
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.PictureBox pB1;
        private System.Windows.Forms.Button btn1;
    }
}

