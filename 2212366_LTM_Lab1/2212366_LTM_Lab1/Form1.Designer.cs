namespace _2212366_LTM_Lab1
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
            this.txtTenMien = new System.Windows.Forms.TextBox();
            this.btnPhanGiai = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên miền : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTenMien
            // 
            this.txtTenMien.AcceptsReturn = true;
            this.txtTenMien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMien.Location = new System.Drawing.Point(235, 56);
            this.txtTenMien.Name = "txtTenMien";
            this.txtTenMien.Size = new System.Drawing.Size(409, 26);
            this.txtTenMien.TabIndex = 1;
            this.txtTenMien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPhanGiai
            // 
            this.btnPhanGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanGiai.Location = new System.Drawing.Point(307, 118);
            this.btnPhanGiai.Name = "btnPhanGiai";
            this.btnPhanGiai.Size = new System.Drawing.Size(223, 50);
            this.btnPhanGiai.TabIndex = 2;
            this.btnPhanGiai.Text = "Phân giải";
            this.btnPhanGiai.UseVisualStyleBackColor = true;
            this.btnPhanGiai.Click += new System.EventHandler(this.btnPhanGiai_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(85, 212);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new System.Drawing.Size(680, 226);
            this.txtKQ.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.btnPhanGiai);
            this.Controls.Add(this.txtTenMien);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenMien;
        private System.Windows.Forms.Button btnPhanGiai;
        private System.Windows.Forms.TextBox txtKQ;
    }
}

