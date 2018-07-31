namespace barDuckDemo
{
    partial class Form2
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
            this.btnAnswer1 = new MetroFramework.Controls.MetroButton();
            this.btnAnswer2 = new MetroFramework.Controls.MetroButton();
            this.btnAnswer3 = new MetroFramework.Controls.MetroButton();
            this.lblQuestion2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Location = new System.Drawing.Point(54, 300);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(292, 49);
            this.btnAnswer1.TabIndex = 1;
            this.btnAnswer1.Text = "Pop";
            this.btnAnswer1.UseSelectable = true;
            this.btnAnswer1.Click += new System.EventHandler(this.btnAnswer1_Click);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Location = new System.Drawing.Point(54, 370);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(292, 49);
            this.btnAnswer2.TabIndex = 2;
            this.btnAnswer2.Text = "Rock";
            this.btnAnswer2.UseSelectable = true;
            this.btnAnswer2.Click += new System.EventHandler(this.btnAnswer2_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Location = new System.Drawing.Point(54, 436);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(292, 49);
            this.btnAnswer3.TabIndex = 3;
            this.btnAnswer3.Text = "Canlı Müzik";
            this.btnAnswer3.UseSelectable = true;
            this.btnAnswer3.Click += new System.EventHandler(this.btnAnswer3_Click);
            // 
            // lblQuestion2
            // 
            this.lblQuestion2.AutoSize = true;
            this.lblQuestion2.Location = new System.Drawing.Point(54, 233);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(190, 19);
            this.lblQuestion2.TabIndex = 4;
            this.lblQuestion2.Text = "Ne tür müzik dinlemek istersin?";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 711);
            this.Controls.Add(this.lblQuestion2);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.btnAnswer1);
            this.Name = "Form2";
            this.Text = "barDuck Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAnswer1;
        private MetroFramework.Controls.MetroButton btnAnswer2;
        private MetroFramework.Controls.MetroButton btnAnswer3;
        private MetroFramework.Controls.MetroLabel lblQuestion2;
    }
}