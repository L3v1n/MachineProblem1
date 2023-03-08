namespace MachineProblem1
{
    partial class Main
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPropa = new System.Windows.Forms.Button();
            this.btnApprox = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 113);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(485, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Machine Problem 1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Programmed by: Ormin Cariaso, Elvin Cervania, Felix Buna";
            // 
            // btnPropa
            // 
            this.btnPropa.AutoSize = true;
            this.btnPropa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropa.Location = new System.Drawing.Point(60, 250);
            this.btnPropa.Name = "btnPropa";
            this.btnPropa.Size = new System.Drawing.Size(365, 34);
            this.btnPropa.TabIndex = 3;
            this.btnPropa.Text = "Propagation Error with Approximation Calculator";
            this.btnPropa.UseVisualStyleBackColor = true;
            this.btnPropa.MouseCaptureChanged += new System.EventHandler(this.btnPropa_MouseCaptureChanged);
            // 
            // btnApprox
            // 
            this.btnApprox.AutoSize = true;
            this.btnApprox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprox.Location = new System.Drawing.Point(60, 310);
            this.btnApprox.Name = "btnApprox";
            this.btnApprox.Size = new System.Drawing.Size(365, 34);
            this.btnApprox.TabIndex = 4;
            this.btnApprox.Text = "Taylor\'s and Maclaurin with Approximation Calculator";
            this.btnApprox.UseVisualStyleBackColor = true;
            this.btnApprox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnApprox_MouseClick);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(190, 390);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 34);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Exit";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBack_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "For Numerical Analysis";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnApprox);
            this.Controls.Add(this.btnPropa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Machine Problem 1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPropa;
        private System.Windows.Forms.Button btnApprox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
    }
}