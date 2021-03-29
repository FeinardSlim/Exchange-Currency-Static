using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exchange_Currency_Static
{
    public partial class Form1 : Form
    {
        private double inValue, outValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inCurrency.Text = "IDR";
            outCurrency.Text = "USD";
            inCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            outCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            outputs.ReadOnly = false;
            inValue = 0;
            outValue = 0;
            inputs.Text = Convert.ToString(0);
        }

        private void inputs_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inputs.Text)) inputs.Text = Convert.ToString("0");
            calculations();
        }

        private void inCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculations();
        }

        private void outCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculations();
        }

        private void outputs_TextChanged(object sender, EventArgs e)
        {

        }
        private void calculations()
        {
            switch (inCurrency.Text)
            {
                case "IDR":
                    this.inValue = 1;
                    break;
                case "USD":
                    this.inValue = 0.000069;
                    break;
                case "GBP":
                    this.inValue = 0.000050;
                    break;
                case "EUR":
                    this.inValue = 0.000059;
                    break;
                case "NTD":
                    this.inValue = 0.0020;
                    break;
                case "SGD":
                    this.inValue = 0.000093;
                    break;
                case "CAD":
                    this.inValue = 0.000087;
                    break;
                case "AUD":
                    this.inValue = 0.000091;
                    break;
                case "PHP":
                    this.inValue = 0.0034;
                    break;
                case "HKD":
                    this.inValue = 0.000538;
                    break;
                default:
                    this.inValue = 1;
                    break;
            }
            switch (outCurrency.Text)
            {
                case "IDR":
                    this.outValue = 1;
                    break;
                case "USD":
                    this.outValue = 0.000069;
                    break;
                case "GBP":
                    this.outValue = 0.000050;
                    break;
                case "EUR":
                    this.outValue = 0.000059;
                    break;
                case "NTD":
                    this.outValue = 0.0020;
                    break;
                case "SGD":
                    this.outValue = 0.000093;
                    break;
                case "CAD":
                    this.outValue = 0.000087;
                    break;
                case "AUD":
                    this.outValue = 0.000091;
                    break;
                case "PHP":
                    this.outValue = 0.0034;
                    break;
                case "HKD":
                    this.outValue = 0.000538;
                    break;
                default:
                    this.outValue = 1;
                    break;
            }
            float input;
            if (String.IsNullOrEmpty(inputs.Text)) input = 0;
            else input = float.Parse(inputs.Text);
            outputs.Text = Convert.ToString(((outValue / inValue)) * input);
        }

    }
}
