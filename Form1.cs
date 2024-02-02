using System;
using System.Data;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text=txtTotal.Text+"4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text=txtTotal.Text+"5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text=txtTotal.Text+"6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text=txtTotal.Text+"-";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text=txtTotal.Text+"2";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtTotal.Clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtTotal.Text=txtTotal.Text+"1";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text=txtTotal.Text+"3";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text=txtTotal.Text+"7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text=txtTotal.Text+"8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text=txtTotal.Text+"9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text=txtTotal.Text+"0";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtTotal.Text=txtTotal.Text+"+";
        }

        private void bt_Click(object sender, EventArgs e)
        {
            txtTotal.Text=txtTotal.Text+"*";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            txtTotal.Text=txtTotal.Text+"/";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            //
            // int equal = Convert.ToInt32(txtTotal.Text);
            string equal = new DataTable().Compute(txtTotal.Text.Trim(), null).ToString();
            txtTotal.Text = equal;


        }
    }
}
