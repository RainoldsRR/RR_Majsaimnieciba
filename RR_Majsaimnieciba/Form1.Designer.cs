namespace RR_Majsaimnieciba
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
            this.txt_ienakumi = new System.Windows.Forms.Label();
            this.txtbox_ienakumi1 = new System.Windows.Forms.TextBox();
            this.txtbox_ienakumi2 = new System.Windows.Forms.TextBox();
            this.txt_izdevumi = new System.Windows.Forms.Label();
            this.txtbox_izdevumi1 = new System.Windows.Forms.TextBox();
            this.txtbox_izdevumi2 = new System.Windows.Forms.TextBox();
            this.txtbox_izdevumi3 = new System.Windows.Forms.TextBox();
            this.txtbox_izdevumi4 = new System.Windows.Forms.TextBox();
            this.txt_budzets = new System.Windows.Forms.Label();
            this.btn_aprekinat = new System.Windows.Forms.Button();
            this.txtbox_budzets = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_ienakumi
            // 
            this.txt_ienakumi.AutoSize = true;
            this.txt_ienakumi.Location = new System.Drawing.Point(58, 61);
            this.txt_ienakumi.Name = "txt_ienakumi";
            this.txt_ienakumi.Size = new System.Drawing.Size(179, 13);
            this.txt_ienakumi.TabIndex = 0;
            this.txt_ienakumi.Text = "Ievadiet mājsaimniecības ienākumus";
            // 
            // txtbox_ienakumi1
            // 
            this.txtbox_ienakumi1.Location = new System.Drawing.Point(244, 61);
            this.txtbox_ienakumi1.Name = "txtbox_ienakumi1";
            this.txtbox_ienakumi1.Size = new System.Drawing.Size(100, 20);
            this.txtbox_ienakumi1.TabIndex = 1;
            this.txtbox_ienakumi1.TextChanged += new System.EventHandler(this.txtbox_ienakumi1_TextChanged);
            // 
            // txtbox_ienakumi2
            // 
            this.txtbox_ienakumi2.Location = new System.Drawing.Point(244, 88);
            this.txtbox_ienakumi2.Name = "txtbox_ienakumi2";
            this.txtbox_ienakumi2.Size = new System.Drawing.Size(100, 20);
            this.txtbox_ienakumi2.TabIndex = 2;
            // 
            // txt_izdevumi
            // 
            this.txt_izdevumi.AutoSize = true;
            this.txt_izdevumi.Location = new System.Drawing.Point(58, 156);
            this.txt_izdevumi.Name = "txt_izdevumi";
            this.txt_izdevumi.Size = new System.Drawing.Size(178, 13);
            this.txt_izdevumi.TabIndex = 3;
            this.txt_izdevumi.Text = "Ievadiet mājsaimniecības izdevumus";
            // 
            // txtbox_izdevumi1
            // 
            this.txtbox_izdevumi1.Location = new System.Drawing.Point(243, 156);
            this.txtbox_izdevumi1.Name = "txtbox_izdevumi1";
            this.txtbox_izdevumi1.Size = new System.Drawing.Size(100, 20);
            this.txtbox_izdevumi1.TabIndex = 4;
            // 
            // txtbox_izdevumi2
            // 
            this.txtbox_izdevumi2.Location = new System.Drawing.Point(243, 183);
            this.txtbox_izdevumi2.Name = "txtbox_izdevumi2";
            this.txtbox_izdevumi2.Size = new System.Drawing.Size(100, 20);
            this.txtbox_izdevumi2.TabIndex = 5;
            // 
            // txtbox_izdevumi3
            // 
            this.txtbox_izdevumi3.Location = new System.Drawing.Point(243, 210);
            this.txtbox_izdevumi3.Name = "txtbox_izdevumi3";
            this.txtbox_izdevumi3.Size = new System.Drawing.Size(100, 20);
            this.txtbox_izdevumi3.TabIndex = 6;
            // 
            // txtbox_izdevumi4
            // 
            this.txtbox_izdevumi4.Location = new System.Drawing.Point(243, 237);
            this.txtbox_izdevumi4.Name = "txtbox_izdevumi4";
            this.txtbox_izdevumi4.Size = new System.Drawing.Size(100, 20);
            this.txtbox_izdevumi4.TabIndex = 7;
            // 
            // txt_budzets
            // 
            this.txt_budzets.AutoSize = true;
            this.txt_budzets.Location = new System.Drawing.Point(61, 299);
            this.txt_budzets.Name = "txt_budzets";
            this.txt_budzets.Size = new System.Drawing.Size(45, 13);
            this.txt_budzets.TabIndex = 8;
            this.txt_budzets.Text = "Budžets";
            // 
            // btn_aprekinat
            // 
            this.btn_aprekinat.Location = new System.Drawing.Point(64, 316);
            this.btn_aprekinat.Name = "btn_aprekinat";
            this.btn_aprekinat.Size = new System.Drawing.Size(75, 23);
            this.btn_aprekinat.TabIndex = 9;
            this.btn_aprekinat.Text = "Aprēķināt";
            this.btn_aprekinat.UseVisualStyleBackColor = true;
            this.btn_aprekinat.Click += new System.EventHandler(this.btn_aprekinat_Click);
            // 
            // txtbox_budzets
            // 
            this.txtbox_budzets.Location = new System.Drawing.Point(137, 292);
            this.txtbox_budzets.Name = "txtbox_budzets";
            this.txtbox_budzets.Size = new System.Drawing.Size(100, 20);
            this.txtbox_budzets.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbox_budzets);
            this.Controls.Add(this.btn_aprekinat);
            this.Controls.Add(this.txt_budzets);
            this.Controls.Add(this.txtbox_izdevumi4);
            this.Controls.Add(this.txtbox_izdevumi3);
            this.Controls.Add(this.txtbox_izdevumi2);
            this.Controls.Add(this.txtbox_izdevumi1);
            this.Controls.Add(this.txt_izdevumi);
            this.Controls.Add(this.txtbox_ienakumi2);
            this.Controls.Add(this.txtbox_ienakumi1);
            this.Controls.Add(this.txt_ienakumi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_ienakumi;
        private System.Windows.Forms.TextBox txtbox_ienakumi1;
        private System.Windows.Forms.TextBox txtbox_ienakumi2;
        private System.Windows.Forms.Label txt_izdevumi;
        private System.Windows.Forms.TextBox txtbox_izdevumi1;
        private System.Windows.Forms.TextBox txtbox_izdevumi2;
        private System.Windows.Forms.TextBox txtbox_izdevumi3;
        private System.Windows.Forms.TextBox txtbox_izdevumi4;
        private System.Windows.Forms.Label txt_budzets;
        private System.Windows.Forms.Button btn_aprekinat;
        private System.Windows.Forms.TextBox txtbox_budzets;
    }
}

