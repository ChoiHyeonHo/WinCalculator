using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalculator
{
    public partial class Form1 : Form
    {
        char op;
        int savedValue;
        private bool opFlag = false;
        private bool memFlag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            try
            {
                if (label1.Text == "0" || opFlag == true || memFlag == true)
                {
                    label1.Text = btn.Text;
                    opFlag = false;
                    memFlag = false;
                }
                else
                    label1.Text = label1.Text + btn.Text;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                savedValue = int.Parse(label1.Text);
                label2.Text = label1.Text + " + ";
                op = '+';
                opFlag = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                savedValue = int.Parse(label1.Text);
                label2.Text = label1.Text + " - ";
                op = '-';
                opFlag = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnMultip_Click(object sender, EventArgs e)
        {
            try
            {
                savedValue = int.Parse(label1.Text);
                label2.Text = label1.Text + " × ";
                op = '×';
                opFlag = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                savedValue = int.Parse(label1.Text);
                label2.Text = label1.Text + " ÷ ";
                op = '÷';
                opFlag = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int v = int.Parse(label1.Text);
                switch (op)
                {
                    case '+':
                        label1.Text = (savedValue + v).ToString();
                        break;
                    case '-':
                        label1.Text = (savedValue - v).ToString();
                        break;
                    case '×':
                        label1.Text = (savedValue * v).ToString();
                        break;
                    case '÷':
                        label1.Text = (savedValue / v).ToString();
                        break;
                }
                label2.Text = "";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "0";
                label2.Text = "";
                savedValue = 0;
                op = ' ';
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
    }
}
