namespace barDuckDemo
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.labelResult = new MetroFramework.Controls.MetroLabel();
            this.lblArza = new MetroFramework.Controls.MetroLabel();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQr = new MetroFramework.Controls.MetroButton();
            this.btn_Location = new MetroFramework.Controls.MetroButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(84, 270);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 0);
            this.labelResult.TabIndex = 0;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArza
            // 
            this.lblArza.AutoSize = true;
            this.lblArza.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblArza.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblArza.Location = new System.Drawing.Point(23, 63);
            this.lblArza.Name = "lblArza";
            this.lblArza.Size = new System.Drawing.Size(61, 25);
            this.lblArza.TabIndex = 1;
            this.lblArza.Text = "ARZA";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ımageList3
            // 
            this.ımageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(445, 421);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 244);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnQr
            // 
            this.btnQr.Location = new System.Drawing.Point(445, 684);
            this.btnQr.Name = "btnQr";
            this.btnQr.Size = new System.Drawing.Size(281, 44);
            this.btnQr.TabIndex = 5;
            this.btnQr.Text = "GET QR CODE";
            this.btnQr.UseSelectable = true;
            this.btnQr.Click += new System.EventHandler(this.btnQr_Click);
            // 
            // btn_Location
            // 
            this.btn_Location.Location = new System.Drawing.Point(445, 350);
            this.btn_Location.Name = "btn_Location";
            this.btn_Location.Size = new System.Drawing.Size(281, 44);
            this.btn_Location.TabIndex = 6;
            this.btn_Location.Text = "GET LOCATION";
            this.btn_Location.UseSelectable = true;
            this.btn_Location.Click += new System.EventHandler(this.btn_Location_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(23, 93);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(703, 251);
            this.webBrowser1.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 782);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btn_Location);
            this.Controls.Add(this.btnQr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblArza);
            this.Controls.Add(this.labelResult);
            this.Name = "Form3";
            this.Text = "barDuck Demo";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelResult;
        private MetroFramework.Controls.MetroLabel lblArza;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.ImageList ımageList3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnQr;
        private MetroFramework.Controls.MetroButton btn_Location;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}