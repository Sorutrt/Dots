namespace Dots
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxPositionX = new System.Windows.Forms.TextBox();
            this.txtboxPositionY = new System.Windows.Forms.TextBox();
            this.btnDot = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(779, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(779, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            // 
            // txtboxPositionX
            // 
            this.txtboxPositionX.Location = new System.Drawing.Point(803, 384);
            this.txtboxPositionX.Name = "txtboxPositionX";
            this.txtboxPositionX.Size = new System.Drawing.Size(100, 19);
            this.txtboxPositionX.TabIndex = 2;
            this.txtboxPositionX.TabStop = false;
            this.txtboxPositionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtboxPositionY
            // 
            this.txtboxPositionY.Location = new System.Drawing.Point(803, 409);
            this.txtboxPositionY.Name = "txtboxPositionY";
            this.txtboxPositionY.Size = new System.Drawing.Size(100, 19);
            this.txtboxPositionY.TabIndex = 3;
            this.txtboxPositionY.TabStop = false;
            this.txtboxPositionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(828, 466);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(75, 23);
            this.btnDot.TabIndex = 4;
            this.btnDot.Text = "Dot!";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(744, 477);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.txtboxPositionY);
            this.Controls.Add(this.txtboxPositionX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dots(Dotter)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxPositionX;
        private System.Windows.Forms.TextBox txtboxPositionY;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

