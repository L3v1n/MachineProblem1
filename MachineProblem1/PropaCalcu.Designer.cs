namespace MachineProblem1
{
    partial class PropaCalcu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExpress = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtCalc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApprox = new System.Windows.Forms.TextBox();
            this.gbApprox = new System.Windows.Forms.GroupBox();
            this.rbRound = new System.Windows.Forms.RadioButton();
            this.rbChop = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnApprox = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbApprox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(450, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Propagation Error with Approximation Calculator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter an expression";
            // 
            // txtExpress
            // 
            this.txtExpress.Location = new System.Drawing.Point(70, 90);
            this.txtExpress.Name = "txtExpress";
            this.txtExpress.Size = new System.Drawing.Size(200, 25);
            this.txtExpress.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtExpress, "Accepted equations:\r\nn + n, n - n, n * n, n / n, n^pow, pi, e");
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 20;
            // 
            // txtCalc
            // 
            this.txtCalc.Location = new System.Drawing.Point(70, 150);
            this.txtCalc.Name = "txtCalc";
            this.txtCalc.ReadOnly = true;
            this.txtCalc.Size = new System.Drawing.Size(200, 25);
            this.txtCalc.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtCalc, "Accepted equations:\r\nn + n, n - n, n * n, n / n, n^pow, pi, e");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Result";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(310, 115);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 34);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCalc_MouseClick);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(310, 480);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 34);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnReset_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Decmial places to approximate";
            // 
            // txtApprox
            // 
            this.txtApprox.Enabled = false;
            this.txtApprox.Location = new System.Drawing.Point(70, 270);
            this.txtApprox.Name = "txtApprox";
            this.txtApprox.Size = new System.Drawing.Size(100, 25);
            this.txtApprox.TabIndex = 10;
            // 
            // gbApprox
            // 
            this.gbApprox.Controls.Add(this.rbRound);
            this.gbApprox.Controls.Add(this.rbChop);
            this.gbApprox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbApprox.Location = new System.Drawing.Point(70, 215);
            this.gbApprox.Name = "gbApprox";
            this.gbApprox.Size = new System.Drawing.Size(340, 50);
            this.gbApprox.TabIndex = 7;
            this.gbApprox.TabStop = false;
            this.gbApprox.Text = "Approximation method";
            // 
            // rbRound
            // 
            this.rbRound.AutoSize = true;
            this.rbRound.Enabled = false;
            this.rbRound.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRound.Location = new System.Drawing.Point(10, 20);
            this.rbRound.Name = "rbRound";
            this.rbRound.Size = new System.Drawing.Size(88, 21);
            this.rbRound.TabIndex = 8;
            this.rbRound.TabStop = true;
            this.rbRound.Text = "Rounding";
            this.rbRound.UseVisualStyleBackColor = true;
            // 
            // rbChop
            // 
            this.rbChop.AutoSize = true;
            this.rbChop.Enabled = false;
            this.rbChop.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChop.Location = new System.Drawing.Point(140, 20);
            this.rbChop.Name = "rbChop";
            this.rbChop.Size = new System.Drawing.Size(88, 21);
            this.rbChop.TabIndex = 9;
            this.rbChop.TabStop = true;
            this.rbChop.Text = "Chopping";
            this.rbChop.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(70, 345);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(340, 123);
            this.listBox1.TabIndex = 13;
            this.listBox1.TabStop = false;
            this.listBox1.UseTabStops = false;
            // 
            // btnApprox
            // 
            this.btnApprox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprox.Location = new System.Drawing.Point(180, 480);
            this.btnApprox.Name = "btnApprox";
            this.btnApprox.Size = new System.Drawing.Size(120, 34);
            this.btnApprox.TabIndex = 15;
            this.btnApprox.Text = "Approximate";
            this.btnApprox.UseVisualStyleBackColor = true;
            this.btnApprox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnApprox_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Answer";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(70, 480);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 34);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBack_MouseClick);
            // 
            // PropaCalcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCalc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApprox);
            this.Controls.Add(this.gbApprox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnApprox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExpress);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PropaCalcu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Machine Problem 1";
            this.Load += new System.EventHandler(this.PropaCalcu_Load);
            this.gbApprox.ResumeLayout(false);
            this.gbApprox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExpress;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApprox;
        private System.Windows.Forms.GroupBox gbApprox;
        private System.Windows.Forms.RadioButton rbRound;
        private System.Windows.Forms.RadioButton rbChop;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnApprox;
        private System.Windows.Forms.TextBox txtCalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
    }
}