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
using System.Text.RegularExpressions;

namespace MachineProblem1
{
    public partial class PropaCalcu : Form
    {
        static double result, absoluteError, relativeError, roundedResult;
        public PropaCalcu()
        {
            InitializeComponent();
        }
        private void PropaCalcu_Load(object sender, EventArgs e)
        {
            btnApprox.Enabled = false;
        }
        private void btnCalc_MouseClick(object sender, MouseEventArgs e)
        {
            btnApprox.Enabled = true;
            if (txtExpress.Text == string.Empty)
            {
                MessageBox.Show("Enter values", "No values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string input = txtExpress.Text;
            
            try
            {
                result = EvaluateExpression(input);
                txtCalc.Text = ($"{result}");            
                if (MessageBox.Show("Choose approximation method to use, and it's values", "Approximation possible", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    rbRound.Enabled = true;
                    rbChop.Enabled = true;
                    txtApprox.Enabled = true;
                    txtExpress.Enabled = false;
                    btnCalc.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        private void btnApprox_MouseClick(object sender, MouseEventArgs e)
        {
            int decimalPlaces;         
            if (rbRound.Checked == false & rbChop.Checked == false)
            {
                MessageBox.Show("Choose approximation method", "No approximation chosen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (rbRound.Checked)
            {
                if (txtApprox.Text == string.Empty)
                {
                    MessageBox.Show("Enter a value for decimal", "No values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                decimalPlaces = int.Parse(txtApprox.Text);
                roundedResult = Math.Round(result, decimalPlaces);
            }
            if (rbChop.Checked)
            {
                if (txtApprox.Text == string.Empty)
                {
                    MessageBox.Show("Enter a value for decimal", "No values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                decimalPlaces = int.Parse(txtApprox.Text);
                double multiplier = Math.Pow(10, decimalPlaces);
                roundedResult = Math.Floor(result * multiplier) / multiplier;
            }
            Approximation();
            listBox1.Items.Add($"Approximated value: {roundedResult}");
            listBox1.Items.Add($"Absolute error: {absoluteError}");
            if (relativeError > 1)
            {
                listBox1.Items.Add($"Relative error: {relativeError * 100:F2}% (move decimal point to the left)");
            }
            else
            {
                listBox1.Items.Add($"Relative error: {relativeError * 100:F2}%");
            }
            rbRound.Enabled = false;
            rbChop.Enabled = false;
            txtApprox.Enabled = false;
            btnApprox.Enabled = false;
        }
        private void btnReset_MouseClick(object sender, MouseEventArgs e)
        {
            txtExpress.Enabled = true;
            btnCalc.Enabled = true;
            rbRound.Checked = false;
            rbChop.Checked = false;
            rbRound.Enabled = false;
            rbChop.Enabled = false;
            txtApprox.Enabled = false;
            btnApprox.Enabled = false;
            listBox1.Items.Clear();
            txtExpress.Clear();
            txtCalc.Clear();
            txtApprox.Clear();
            txtExpress.Focus();
        }
        private void btnBack_MouseClick(object sender, MouseEventArgs e)
        {
            Main f1 = new Main();
            f1.Show();
            this.Hide();
        }
        static void Approximation()
        {
            absoluteError = Math.Abs(roundedResult - result);
            relativeError = absoluteError / result;
        }
        static double EvaluateExpression(string expression)
        {
            var regex = new Regex(@"(?<!\w)(pi|e)(?!\w)");
            expression = regex.Replace(expression, match =>
            {
                switch (match.Value)
                {
                    case "pi":
                        return Math.PI.ToString();
                    case "e":
                        return Math.E.ToString();
                    default:
                        return match.Value;
                }
            });
            expression = Regex.Replace(expression, @"(\d+)\s*\^\s*(\d+)", match =>
            {
                double x = double.Parse(match.Groups[1].Value);
                double y = double.Parse(match.Groups[2].Value);
                return Math.Pow(x, y).ToString();
            });
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return Convert.ToDouble(row["expression"]);            
        }
    }
}
