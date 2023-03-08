namespace MachineProblem1
{
    partial class ApproxCalcu
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
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.rbTaylor = new System.Windows.Forms.RadioButton();
            this.rbMaclaurin = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbSeries = new System.Windows.Forms.GroupBox();
            this.gbApprox = new System.Windows.Forms.GroupBox();
            this.rbRound = new System.Windows.Forms.RadioButton();
            this.rbChop = new System.Windows.Forms.RadioButton();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtApprox = new System.Windows.Forms.TextBox();
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.gbSeries.SuspendLayout();
            this.gbApprox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(485, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Taylor\'s and Maclaurin with Approximation Calculator\r\n";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFunction
            // 
            this.txtFunction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFunction.Location = new System.Drawing.Point(70, 75);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.ReadOnly = true;
            this.txtFunction.Size = new System.Drawing.Size(340, 25);
            this.txtFunction.TabIndex = 1;
            this.txtFunction.Text = "f(x) = 1/(1-x)";
            this.toolTip1.SetToolTip(this.txtFunction, "Enter a value for the function f(x)");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter a funcion f(x)";
            // 
            // txtPoint
            // 
            this.txtPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPoint.Location = new System.Drawing.Point(70, 130);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(100, 25);
            this.txtPoint.TabIndex = 3;
            this.toolTip2.SetToolTip(this.txtPoint, "Enter a point for the value of x in the function f(x)");
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter a point";
            // 
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 100;
            this.toolTip2.AutoPopDelay = 5000;
            this.toolTip2.InitialDelay = 100;
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ReshowDelay = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Order";
            // 
            // txtOrder
            // 
            this.txtOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrder.Location = new System.Drawing.Point(70, 185);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(100, 25);
            this.txtOrder.TabIndex = 5;
            this.toolTip3.SetToolTip(this.txtOrder, "Set the maximum value of power");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "n";
            // 
            // toolTip3
            // 
            this.toolTip3.AutomaticDelay = 100;
            this.toolTip3.AutoPopDelay = 5000;
            this.toolTip3.InitialDelay = 100;
            this.toolTip3.IsBalloon = true;
            this.toolTip3.ReshowDelay = 20;
            // 
            // rbTaylor
            // 
            this.rbTaylor.AutoSize = true;
            this.rbTaylor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTaylor.Location = new System.Drawing.Point(10, 20);
            this.rbTaylor.Name = "rbTaylor";
            this.rbTaylor.Size = new System.Drawing.Size(121, 21);
            this.rbTaylor.TabIndex = 8;
            this.rbTaylor.TabStop = true;
            this.rbTaylor.Text = "Taylor\'s Series";
            this.rbTaylor.UseVisualStyleBackColor = true;
            this.rbTaylor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbTaylor_MouseClick);
            // 
            // rbMaclaurin
            // 
            this.rbMaclaurin.AutoSize = true;
            this.rbMaclaurin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaclaurin.Location = new System.Drawing.Point(10, 50);
            this.rbMaclaurin.Name = "rbMaclaurin";
            this.rbMaclaurin.Size = new System.Drawing.Size(134, 21);
            this.rbMaclaurin.TabIndex = 9;
            this.rbMaclaurin.TabStop = true;
            this.rbMaclaurin.Text = "Maclaurin Series";
            this.rbMaclaurin.UseVisualStyleBackColor = true;
            this.rbMaclaurin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbMaclaurin_MouseClick);
            // 
            // btnCalc
            // 
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(190, 506);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 34);
            this.btnCalc.TabIndex = 22;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Visible = false;
            this.btnCalc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCalc_MouseClick);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(70, 375);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(165, 87);
            this.listBox1.TabIndex = 16;
            this.listBox1.TabStop = false;
            this.listBox1.UseTabStops = false;
            // 
            // gbSeries
            // 
            this.gbSeries.BackColor = System.Drawing.Color.Transparent;
            this.gbSeries.Controls.Add(this.rbTaylor);
            this.gbSeries.Controls.Add(this.rbMaclaurin);
            this.gbSeries.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSeries.Location = new System.Drawing.Point(200, 130);
            this.gbSeries.Name = "gbSeries";
            this.gbSeries.Size = new System.Drawing.Size(210, 80);
            this.gbSeries.TabIndex = 7;
            this.gbSeries.TabStop = false;
            this.gbSeries.Text = "Expansion method";
            this.toolTip4.SetToolTip(this.gbSeries, "Choose what expansion series to use");
            // 
            // gbApprox
            // 
            this.gbApprox.BackColor = System.Drawing.Color.Transparent;
            this.gbApprox.Controls.Add(this.rbRound);
            this.gbApprox.Controls.Add(this.rbChop);
            this.gbApprox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbApprox.Location = new System.Drawing.Point(70, 245);
            this.gbApprox.Name = "gbApprox";
            this.gbApprox.Size = new System.Drawing.Size(340, 50);
            this.gbApprox.TabIndex = 10;
            this.gbApprox.TabStop = false;
            this.gbApprox.Text = "Approximation method";
            this.toolTip5.SetToolTip(this.gbApprox, "Choose what kind of approximation to use");
            // 
            // rbRound
            // 
            this.rbRound.AutoSize = true;
            this.rbRound.Enabled = false;
            this.rbRound.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRound.Location = new System.Drawing.Point(10, 20);
            this.rbRound.Name = "rbRound";
            this.rbRound.Size = new System.Drawing.Size(88, 21);
            this.rbRound.TabIndex = 11;
            this.rbRound.TabStop = true;
            this.rbRound.Text = "Rounding";
            this.rbRound.UseVisualStyleBackColor = true;
            this.rbRound.CheckedChanged += new System.EventHandler(this.rbRound_CheckedChanged);
            // 
            // rbChop
            // 
            this.rbChop.AutoSize = true;
            this.rbChop.Enabled = false;
            this.rbChop.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChop.Location = new System.Drawing.Point(140, 20);
            this.rbChop.Name = "rbChop";
            this.rbChop.Size = new System.Drawing.Size(88, 21);
            this.rbChop.TabIndex = 12;
            this.rbChop.TabStop = true;
            this.rbChop.Text = "Chopping";
            this.rbChop.UseVisualStyleBackColor = true;
            this.rbChop.CheckedChanged += new System.EventHandler(this.rbChop_CheckedChanged);
            // 
            // toolTip4
            // 
            this.toolTip4.AutomaticDelay = 100;
            this.toolTip4.AutoPopDelay = 5000;
            this.toolTip4.InitialDelay = 100;
            this.toolTip4.IsBalloon = true;
            this.toolTip4.ReshowDelay = 20;
            // 
            // toolTip5
            // 
            this.toolTip5.AutomaticDelay = 100;
            this.toolTip5.AutoPopDelay = 5000;
            this.toolTip5.InitialDelay = 100;
            this.toolTip5.IsBalloon = true;
            this.toolTip5.ReshowDelay = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Decmial places to approximate";
            // 
            // txtApprox
            // 
            this.txtApprox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApprox.Enabled = false;
            this.txtApprox.Location = new System.Drawing.Point(70, 300);
            this.txtApprox.Name = "txtApprox";
            this.txtApprox.Size = new System.Drawing.Size(100, 25);
            this.txtApprox.TabIndex = 13;
            this.toolTip6.SetToolTip(this.txtApprox, "Enter number of decimal places to approximate");
            // 
            // toolTip6
            // 
            this.toolTip6.AutomaticDelay = 100;
            this.toolTip6.AutoPopDelay = 5000;
            this.toolTip6.InitialDelay = 100;
            this.toolTip6.IsBalloon = true;
            this.toolTip6.ReshowDelay = 20;
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(310, 506);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 34);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnReset_MouseClick);
            // 
            // btnCheck
            // 
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(190, 506);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 34);
            this.btnCheck.TabIndex = 20;
            this.btnCheck.Text = "Calculate";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCheck_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Result";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(70, 506);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 34);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBack_MouseClick);
            // 
            // listBox3
            // 
            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.HorizontalScrollbar = true;
            this.listBox3.ItemHeight = 17;
            this.listBox3.Location = new System.Drawing.Point(245, 375);
            this.listBox3.Name = "listBox3";
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox3.Size = new System.Drawing.Size(165, 87);
            this.listBox3.TabIndex = 17;
            this.listBox3.TabStop = false;
            this.listBox3.UseTabStops = false;
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 17;
            this.listBox2.Location = new System.Drawing.Point(70, 465);
            this.listBox2.MultiColumn = true;
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(340, 36);
            this.listBox2.TabIndex = 18;
            this.listBox2.TabStop = false;
            this.listBox2.UseTabStops = false;
            // 
            // ApproxCalcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApprox);
            this.Controls.Add(this.gbApprox);
            this.Controls.Add(this.gbSeries);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFunction);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "ApproxCalcu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Machine Problem 1";
            this.Load += new System.EventHandler(this.ApproxCalcu_Load);
            this.gbSeries.ResumeLayout(false);
            this.gbSeries.PerformLayout();
            this.gbApprox.ResumeLayout(false);
            this.gbApprox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbTaylor;
        private System.Windows.Forms.RadioButton rbMaclaurin;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox gbSeries;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.GroupBox gbApprox;
        private System.Windows.Forms.RadioButton rbRound;
        private System.Windows.Forms.RadioButton rbChop;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApprox;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
    }
}

