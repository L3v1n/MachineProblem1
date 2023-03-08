//Collaborated work by: BCC//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineProblem1
{
    public partial class ApproxCalcu : Form
    {
        static double a;
        static int n;
        static double result = 0;
        static double actualValue, absoluteError, relativeError, coefficient, derivative, power, factorial;
        public ApproxCalcu()
        {
            InitializeComponent();
        }                   
        private void ApproxCalcu_Load(object sender, EventArgs e)
        {
            ActiveControl = txtPoint;
        }
        private void btnCheck_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPoint.Text == string.Empty | txtOrder.Text == string.Empty)
            {                
                MessageBox.Show("Enter values", "No values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
            if (rbTaylor.Checked == false & rbMaclaurin.Checked == false)
            {
                MessageBox.Show("Choose polynomial series", "No series chosen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            a = double.Parse(txtPoint.Text);
            n = int.Parse(txtOrder.Text);
            
            if (rbTaylor.Checked)
            {
                if (a == 0)
                {
                    MessageBox.Show("Enter a value for point", "No value for point", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                       
                    return;
                }         
                listBox1.Items.Add("Derivatives:");
                for (int i = 0; i <= n; i++)
                {
                    derivative = Derivative(i, a);
                    listBox1.Items.Add($"f^{i}({a}) = {derivative}");
                }

                listBox2.Items.Add($"Polynomial:");
                for (int i = 0; i <= n; i++)
                {
                    
                    derivative = Derivative(i, a);
                    power = Math.Pow(a, i);
                    factorial = Factorial(i);
                    coefficient = (derivative / factorial);
                    listBox2.Items.Add($"{coefficient}");
                    
                    if (i > 0)
                    {
                        listBox2.Items.Add($"x^{i}");
                    }
                    if (i < n)
                    {
                        listBox2.Items.Add(" + ");
                    }
                }
                for (int i = 0; i <= n; i++)
                {
                    derivative = Derivative(i, a);
                    power = Math.Pow(a, i);
                    factorial = Factorial(i);
                    result += (derivative / factorial) * power;
                }
                listBox1.Items.Add("---------------");
                listBox1.Items.Add($"Taylor Series P({n}) = {result}");
                if (result % 1 != 0)
                {
                    if (MessageBox.Show("Choose approximation method to use, and it's values", "Approximation possible", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        txtFunction.Enabled = false;
                        txtPoint.Enabled = false;
                        txtOrder.Enabled = false;
                        rbTaylor.Enabled = false;
                        rbMaclaurin.Enabled = false;
                        rbRound.Enabled = true;
                        rbChop.Enabled = true;
                        txtApprox.Enabled = true;
                        btnCalc.Visible = true;
                        btnCheck.Visible = false;
                    }                    
                    else
                    {                     
                        txtFunction.Enabled = false;
                        txtPoint.Enabled = false;
                        txtOrder.Enabled = false;
                        rbTaylor.Enabled = false;
                        rbMaclaurin.Enabled = false;
                        btnCheck.Enabled = false;
                        btnCalc.Enabled = false;
                        Approximation();
                        listBox3.Items.Add($"Absolute Error: {absoluteError}");
                        listBox3.Items.Add($"Relative Error: {relativeError * 100:F2}%");
                    }             
                }               
            }
            if (rbMaclaurin.Checked)
            {
                a = 0;
                listBox1.Items.Add("Derivatives:");
                for (int i = 0; i <= n; i++)
                {
                    derivative = Derivative(i, a);
                    listBox1.Items.Add($"f^{i}({a}) = {derivative}");
                }
                listBox2.Items.Add("Polynomial:");
                for (int i = 0; i <= n; i++)
                {
                    derivative = Derivative(i, a);
                    power = Math.Pow(a, i);
                    factorial = Factorial(i);
                    coefficient = (derivative / factorial);
                    listBox2.Items.Add($"{coefficient}");
                    if (i > 0)
                    {
                        listBox2.Items.Add($"x^{i}");
                    }
                    if (i < n)
                    {
                        listBox2.Items.Add(" + ");
                    }
                }
                for (int i = 0; i <= n; i++)
                {
                    derivative = Derivative(i, a);
                    power = Math.Pow(a, i);
                    factorial = Factorial(i);
                    result += (derivative / factorial) * power;
                }
                listBox1.Items.Add("---------------");
                listBox1.Items.Add($"Mclaurin Series P({n}) = {result}");
                txtFunction.Enabled = false;
                txtPoint.Enabled = false;
                txtOrder.Enabled = false;
                rbTaylor.Enabled = false;
                rbMaclaurin.Enabled = false;
                btnCheck.Enabled = false;
                btnCalc.Enabled = false;
                Approximation();
                listBox3.Items.Add($"Absolute Error: {absoluteError}");
                listBox3.Items.Add($"Relative Error: {relativeError * 100:F2}%");
            }
        }
        private void btnCalc_MouseClick(object sender, MouseEventArgs e)
        {
            txtFunction.Enabled = false;
            txtPoint.Enabled = false;
            txtOrder.Enabled = false;
            rbTaylor.Enabled = false;
            rbMaclaurin.Enabled = false;
            int decimalPlaces;         
            if (rbRound.Checked == false & rbChop.Checked == false)
            {
                MessageBox.Show("Choose approximation method", "No approximation chosen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (result % 1 != 0)
            {
                if (rbRound.Checked)
                {                    
                    if (txtApprox.Text == string.Empty)
                    {
                        MessageBox.Show("Enter a value for decimal", "No values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    decimalPlaces = int.Parse(txtApprox.Text);
                    result = Math.Round(result, decimalPlaces);
                    listBox3.Items.Add($"Rounded Taylor's Polynomial Value: {result}");
                    listBox3.Items.Add($"--------------------");
                }
                if (rbChop.Checked)
                {                    
                    if (txtApprox.Text == string.Empty)
                    {
                        MessageBox.Show("Enter a value for decimal", "No values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    decimalPlaces = int.Parse(txtApprox.Text);
                    result = Math.Truncate(result * Math.Pow(10, decimalPlaces)) / Math.Pow(10, decimalPlaces);                   
                    listBox3.Items.Add($"Chopped Taylor's Polynomial Value: {result}");
                    listBox3.Items.Add($"--------------------");
                }            
                txtApprox.Enabled = false;
                rbRound.Enabled = false;
                rbChop.Enabled = false;
                btnCheck.Enabled = false;
                btnCalc.Enabled = false;
            }
            Approximation();
            listBox3.Items.Add($"Absolute Error: {absoluteError}");
            listBox3.Items.Add($"Relative Error: {relativeError * 100:F2}%");
        }        
        private void rbTaylor_MouseClick(object sender, MouseEventArgs e)
        {
            txtPoint.Enabled = true;
        }
        private void rbMaclaurin_MouseClick(object sender, MouseEventArgs e)
        {
            txtPoint.Text = "0";
            txtPoint.Enabled = false;
        }
        private void rbRound_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "Number of decimal places to round to";
        }
        private void rbChop_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "Number of decimal places to chop to";
        }
        private void btnReset_MouseClick(object sender, MouseEventArgs e)
        {
            txtPoint.Clear();
            txtOrder.Clear();
            txtApprox.Clear();                       
            txtPoint.Focus();
            txtFunction.Enabled = true;
            txtPoint.Enabled = true;
            txtOrder.Enabled = true;
            txtApprox.Enabled = false;
            rbTaylor.Enabled = true;
            rbMaclaurin.Enabled = true;
            rbTaylor.Checked = false;
            rbMaclaurin.Checked = false;
            rbRound.Checked = false;
            rbChop.Checked = false;
            rbRound.Enabled = false;
            rbChop.Enabled = false;
            listBox1.Items.Clear();    
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            btnCheck.Enabled = true;
            btnCalc.Enabled = true;
            btnCheck.Visible = true;           
            btnCalc.Visible = false;
        }        
        static void Approximation()
        {
            actualValue = 1 / (1 - a);
            absoluteError = Math.Abs(actualValue - result);
            relativeError = Math.Abs((actualValue - result) / actualValue);
        }
        private void btnBack_MouseClick(object sender, MouseEventArgs e)
        {
            Main f1 = new Main();
            f1.Show();
            this.Hide();
        }
        static double Derivative(int order, double a)
        {
            if (order == 0)
            {
                return 1 / (1 - a);
            }
            double numerator = Factorial(order) * Math.Pow(-1, order);
            double denominator = Math.Pow(1 - a, order + 1);
            double result = numerator / denominator;
            if (order % 2 != 0)
            {
                result *= -1;
            }
            return result;
        }
        static double Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
